using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReversePrism
{
    // masterdata.bytes
    public partial class MasterData
    {
        public string?                  FileName                { get; set; }
        public byte                     EntryCount              { get; private set; }
        public List<object>             MasterDatas             { get; private set; } = new ();
        public Dictionary<string, object> MasterDataByName      { get; private set; } = new ();

      //private void Load<K, V>(BinaryReader r, string name, out Dictionary<K, V> values) where K : notnull where V : MasterDataItem, new()
        private void Load<K, V>(BinaryReader r, string name, out SortedDictionary<K, V> values) where K : notnull where V : MasterDataItem, new()
        {
            values  = MasterDataDeserializer.Deserialize<K, V>(r);
            var a   = values.Values.ToArray();

            MasterDatas.Add(a);
            MasterDataByName.Add(name, a);
        }

        private void Load(BinaryReader r, string name)
        {
            var count   = r.ReadInt32();

            MasterDatas.Add(new object[0]);
            MasterDataByName.Add(name, new object[0]);
        }

      //private void Load<T>(BinaryReader r, string name, out T[] values) where T : MasterDataItem, new()
        private void Load<T>(BinaryReader r, string name, out List<T> values) where T : MasterDataItem, new()
        {
            values  = MasterDataDeserializer.Deserialize<T>(r);

            MasterDatas.Add(values);
            MasterDataByName.Add(name, values);
        }

        public static string GetRealName(CatalogASet catalog)
        {
            var label   = CatalogDB.CalcResourceLabel("masterdata.bytes");

            if(!catalog.TryGetValue(label, out var rec))
                throw new InvalidDataException();

            var real    = CatalogDB.GetRealName(rec);

            return real;
        }

        public static MasterData FromPackedFile(string file, long label, long encrypt)
        {
            var packfile= PackedFile.FromEncryptedFile(file, label, encrypt);

            File.WriteAllBytes("G:\\DMM\\imas_scsp\\SONGforPRISM_manage\\hack\\tmp\\master.bytes", packfile.Data);

            var value   = FromBytes(packfile.Data);

            value.FileName  = file;

            return value;
        }

        public static MasterData FromFile(string file)
        {
            using(var s= File.OpenRead(file))
                return FromStream(s);
        }

        public static MasterData FromBytes(byte[] data)
        {
            using(var s= new MemoryStream(data))
                return FromStream(s);
        }

        public static MasterData FromStream(Stream s, bool leaveOpen = true)
        {
            var value   = new MasterData() { FileName= (s as FileStream)?.Name };

            using(var r= new BinaryReader(s))
                value.Load(r);

            return value;
        }
    }

    public static class MasterDataDeserializer
    {
        public delegate void FieldReader(BinaryReader r, object target);
        public delegate object? KeyReader(BinaryReader r);

      //public static Dictionary<K, V> Deserialize<K, V>(BinaryReader r) where K : notnull where V : MasterDataItem, new()
        public static SortedDictionary<K, V> Deserialize<K, V>(BinaryReader r) where K : notnull where V : MasterDataItem, new()
        {
            var position    = r.BaseStream.Position;
          //var keyReader   = GetKeyReader<K>();
            var fields      = GetFieldReaders(typeof(V));
            var count       = r.ReadInt32();

            System.Diagnostics.Debug.Print($"{position:X} {count} {typeof(V).Name}");

          //var values      = new Dictionary<K, V>();
            var values      = new SortedDictionary<K, V>();
            var dic         = (System.Collections.IDictionary)values;
            var fdesc       = typeof(V).GetFields();
            var keygetter   = typeof(K) == typeof(int)        ? new Func<object, object>(v => { return (object)(int)fdesc[0].GetValue(v); })
                            : typeof(K) == typeof((int, int)) ? new Func<object, object>(v => { return (object)((int)fdesc[0].GetValue(v), (int)fdesc[1].GetValue(v)); })
                            : typeof(K) == typeof(string)     ? new Func<object, object>(v => { return (object)(string)fdesc[0].GetValue(v); })
                            : throw new NotSupportedException();


            for(int i= 0; i < count; ++i)
            {
              //var key     = keyReader(r) ?? throw new NullReferenceException();
                var value   = new V();

                foreach(var j in fields)
                    j(r, value);

                if(fields.Count - 1 != value.Fields)
                    throw new InvalidDataException();

                var key     = keygetter(value);

                dic.Add(key, value);
            }

            return values;
        }

      //public static T[] Deserialize<T>(BinaryReader r) where T : MasterDataItem, new()
        public static List<T> Deserialize<T>(BinaryReader r) where T : MasterDataItem, new()
        {
            var position    = r.BaseStream.Position;
            var fields      = GetFieldReaders(typeof(T));
            var count       = r.ReadInt32();

            System.Diagnostics.Debug.Print($"{position:X} {count} {typeof(T).Name}");

          //var values      = new T[count];
            var values      = new List<T>(count);

            for(int i= 0; i < count; ++i)
            {
                var value   = new T();

                values.Add(value);

                foreach(var j in fields)
                    j(r, value);

                System.Diagnostics.Debug.Assert(fields.Count - 1 == value.Fields);
            }

            return values;
        }

        private static List<FieldReader> GetFieldReaders(Type type)
        {
            var fields  = new List<FieldReader>();
            var baseType= type.BaseType ?? throw new NullReferenceException();

            foreach(var i in baseType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                fields.Add(GetFieldReader(i));

            foreach(var i in type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                fields.Add(GetFieldReader(i));

            return fields;
        }

        private static KeyReader GetKeyReader<K>()
        {
            if(typeof(K) == typeof(int))        return (r) => r.ReadInt32();
            if(typeof(K) == typeof((int, int))) return (r) => (r.ReadInt32(), r.ReadInt32());
            if(typeof(K) == typeof(string))     return (r) => ReadString(r);

            throw new NotSupportedException();
        }

        private static FieldReader GetFieldReader(FieldInfo fi)
        {
            var type    = fi.FieldType;

            if(type.IsEnum)
            {
                return (r, target) => fi.SetValue(target, Enum.ToObject(fi.FieldType, r.ReadInt32()));
            } else
            if(type.IsArray)
            {
                type    = fi.FieldType.GetElementType();

                if(type == typeof(bool))     return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadByte() != 0).ToArray());
                if(type == typeof(byte))     return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadByte  ())   .ToArray());
                if(type == typeof(short))    return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt16 ())   .ToArray());
                if(type == typeof(ushort))   return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadUInt16())   .ToArray());
                if(type == typeof(int))      return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt32 ())   .ToArray());
                if(type == typeof(uint))     return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadUInt32())   .ToArray());
                if(type == typeof(long))     return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt64 ())   .ToArray());
                if(type == typeof(ulong))    return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadUInt64())   .ToArray());
                if(type == typeof(float))    return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadSingle())   .ToArray());
                if(type == typeof(double))   return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadDouble())   .ToArray());
                if(type == typeof(string))   return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => ReadString(r))    .ToArray());
                if(type == typeof(DateTime)) return (r, target) => fi.SetValue(target, Enumerable.Range(0, r.ReadInt32()).Select(i => ReadDateTime(r))  .ToArray());
            } else
            {
                if(type == typeof(bool))     return (r, target) => fi.SetValue(target, r.ReadByte  () != 0);
                if(type == typeof(byte))     return (r, target) => fi.SetValue(target, r.ReadByte  ());
                if(type == typeof(short))    return (r, target) => fi.SetValue(target, r.ReadInt16 ());
                if(type == typeof(ushort))   return (r, target) => fi.SetValue(target, r.ReadUInt16());
                if(type == typeof(int))      return (r, target) => fi.SetValue(target, r.ReadInt32 ());
                if(type == typeof(uint))     return (r, target) => fi.SetValue(target, r.ReadUInt32());
                if(type == typeof(long))     return (r, target) => fi.SetValue(target, r.ReadInt64 ());
                if(type == typeof(ulong))    return (r, target) => fi.SetValue(target, r.ReadUInt64());
                if(type == typeof(float))    return (r, target) => fi.SetValue(target, r.ReadSingle());
                if(type == typeof(double))   return (r, target) => fi.SetValue(target, r.ReadDouble());
                if(type == typeof(string))   return (r, target) => fi.SetValue(target, ReadString(r));
                if(type == typeof(DateTime)) return (r, target) => fi.SetValue(target, ReadDateTime(r));
            }

            throw new NotSupportedException();
        }

        private static DateTime ReadDateTime(BinaryReader r)
            =>  DateTime.FromBinary(r.ReadInt64());

        private static string? ReadString(BinaryReader r)
        {
            var size    = r.ReadInt32();

            if(size == 0)
                return null;

            var chars   = r.ReadInt32();
            var value   = Encoding.UTF8.GetString(r.ReadBytes(~size));

            System.Diagnostics.Debug.Assert(value.Length == chars);

            return value;
        }
    }

    public abstract partial class MasterDataItem
    {
        [JsonIgnore]
        public byte                     Fields;
    }
}
