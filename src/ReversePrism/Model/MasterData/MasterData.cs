using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReversePrism
{
    // masterdata.bytes
    public class MasterData
    {
        public string?                  FileName                { get; set; }
        public byte                     EntryCount              { get; private set; }
        public List<MasterDataBase[]>   DataEntries             { get; private set; } = new List<MasterDataBase[]>();
        public IEnumerable<MasterData01> Idol                   => DataEntries[ 0].Cast<MasterData01>();
        public IEnumerable<MasterData03> Unit                   => DataEntries[ 2].Cast<MasterData03>();
        public IEnumerable<MasterData05> Costume                => DataEntries[ 4].Cast<MasterData05>();
        public IEnumerable<MasterData06> Dress                  => DataEntries[ 5].Cast<MasterData06>();
        public IEnumerable<MasterData10> Accessory              => DataEntries[ 9].Cast<MasterData10>();

        public static string GetRealName(CatalogASet catalog)
        {
            var label   = CatalogDB.CalcResourceLabel("masterdata.bytes");

            if(!catalog.TryGetValue(label, out var rec))
                throw new InvalidDataException();

            var real    = CatalogDB.GetResourceName(rec);

            return real;
        }

        private void Load(BinaryReader r)
        {
            EntryCount  = r.ReadByte();

            Load<MasterData01>(r);
            Load<MasterData02>(r);
            Load<MasterData03>(r);
            Load<MasterData04>(r);
            Load<MasterData05>(r);
            Load<MasterData06>(r);
            Load<MasterData07>(r);
            Load<MasterData08>(r);
            Load<MasterData09>(r);
            Load<MasterData10>(r);
            Load<MasterData11>(r);
            Load<MasterData12>(r);
            Load<MasterData13>(r);
            Load<MasterData14>(r);
            Load<MasterData15>(r);
            Load<MasterData16>(r);
            Load<MasterData17>(r);
            Load<MasterData18>(r);
            Load<MasterData19>(r);
            Load<MasterData20>(r);
            Load<MasterData21>(r);
            Load<MasterData22>(r);
            Load<MasterData23>(r);
            Load<MasterData24>(r);
            Load<MasterData25>(r);
            Load<MasterData26>(r);
            Load<MasterData27>(r);
            Load<MasterData28>(r);
            Load<MasterData29>(r);
            Load<MasterData30>(r);
            Load<MasterData31>(r);
            Load<MasterData32>(r);
            Load<MasterData33>(r);
            Load<MasterData34>(r);
            Load<MasterData35>(r);
            Load<MasterData36>(r);
            Load<MasterData37>(r);
            Load<MasterData38>(r);
            Load<MasterData39>(r);
            Load<MasterData40>(r);
            Load<MasterData41>(r);
            Load<MasterData42>(r);
            Load<MasterData43>(r);
            Load<MasterData44>(r);
            Load<MasterData45>(r);
            Load<MasterData46>(r);
            Load<MasterData47>(r);
            Load<MasterData48>(r);
            Load<MasterData49>(r);
            Load<MasterData50>(r);
            Load<MasterData51>(r);
            Load<MasterData52>(r);
            Load<MasterData53>(r);
            Load<MasterData54>(r);
            Load<MasterData55>(r);
            Load<MasterData56>(r);
            Load<MasterData57>(r);
            Load<MasterData58>(r);
            Load<MasterData59>(r);
            Load<MasterData60>(r);
            Load<MasterData61>(r);
            Load<MasterData62>(r);
            Load<MasterData63>(r);
            Load<MasterData64>(r);
            Load<MasterData65>(r);
            Load<MasterData66>(r);
            Load<MasterData67>(r);
            Load<MasterData68>(r);
            Load<MasterData69>(r);
            Load<MasterData70>(r);
            Load<MasterData71>(r);
            Load<MasterData72>(r);
            Load<MasterData73>(r);
            Load<MasterData74>(r);
            Load<MasterData75>(r);
            Load<MasterData76>(r);
            Load<MasterData77>(r);
            Load<MasterData78>(r);
            Load<MasterData79>(r);

            //System.Diagnostics.Debug.Print($"{r.BaseStream.Position:X6}");
            //System.Diagnostics.Debug.Assert(r.BaseStream.Position == r.BaseStream.Length);
        }

        private void Load<T>(BinaryReader r) where T : MasterDataBase, new()
            => DataEntries.Add(MasterDataBase.ReadData<T>(r));

        public static MasterData FromFile(string file)
        {
            using(var s= File.OpenRead(file))
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

    public abstract partial class MasterDataBase
    {
        public byte                     Fields;

        public void ReadFieldCount(BinaryReader r, int verify)
        {
            Fields  = r.ReadByte();

            System.Diagnostics.Debug.Assert(Fields == verify);
        }

        public static T[] ReadData<T>(BinaryReader r) where T : MasterDataBase, new()
        {
            //System.Diagnostics.Debug.Print($"{r.BaseStream.Position:X6}: {typeof(T).Name}");

            var count   = r.ReadInt32();
            var values  = new T[count];

            for(int i= 0; i < count; ++i)
            {
                values[i] = new T();
                values[i].Deserialize(r);
            }

            return values;
        }

        protected abstract void Deserialize(BinaryReader r);

        protected void Read(BinaryReader r, ref byte       value)   => value= r.ReadByte();
        protected void Read(BinaryReader r, ref ushort     value)   => value= r.ReadUInt16();
        protected void Read(BinaryReader r, ref int        value)   => value= r.ReadInt32();
        protected void Read(BinaryReader r, ref long       value)   => value= r.ReadInt64();
        protected void Read(BinaryReader r, ref float      value)   => value= r.ReadSingle();
        protected void Read(BinaryReader r, ref double     value)   => value= r.ReadDouble();
        protected void Read(BinaryReader r, ref int[]?     value)   => value= Enumerable.Range(0, r.ReadInt32()).Select(i => r.ReadInt32()).ToArray();
        protected void Read(BinaryReader r, ref byte[]?    value)   => value= r.ReadBytes(r.ReadInt32());
        protected void Read(BinaryReader r, ref string?    value)   => value= ReadString(r);
        protected void Read(BinaryReader r, ref string?[]? value)   => value= Enumerable.Range(0, r.ReadInt32()).Select(i => ReadString(r)).ToArray();

        protected string? ReadString(BinaryReader r)
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

    public partial class MasterData01 : MasterDataBase    { }
    public partial class MasterData02 : MasterDataBase    { }
    public partial class MasterData03 : MasterDataBase    { }
    public partial class MasterData04 : MasterDataBase    { }
    public partial class MasterData05 : MasterDataBase    { }
    public partial class MasterData06 : MasterDataBase    { }
    public partial class MasterData07 : MasterDataBase    { }
    public partial class MasterData08 : MasterDataBase    { }
    public partial class MasterData09 : MasterDataBase    { }

    public partial class MasterData10 : MasterDataBase    { }
    public partial class MasterData11 : MasterDataBase    { }
    public partial class MasterData12 : MasterDataBase    { }
    public partial class MasterData13 : MasterDataBase    { }
    public partial class MasterData14 : MasterDataBase    { }
    public partial class MasterData15 : MasterDataBase    { }
    public partial class MasterData16 : MasterDataBase    { }
    public partial class MasterData17 : MasterDataBase    { }
    public partial class MasterData18 : MasterDataBase    { }
    public partial class MasterData19 : MasterDataBase    { }

    public partial class MasterData20 : MasterDataBase    { }
    public partial class MasterData21 : MasterDataBase    { }
    public partial class MasterData22 : MasterDataBase    { }
    public partial class MasterData23 : MasterDataBase    { }
    public partial class MasterData24 : MasterDataBase    { }
    public partial class MasterData25 : MasterDataBase    { }
    public partial class MasterData26 : MasterDataBase    { }
    public partial class MasterData27 : MasterDataBase    { }
    public partial class MasterData28 : MasterDataBase    { }
    public partial class MasterData29 : MasterDataBase    { }

    public partial class MasterData30 : MasterDataBase    { }
    public partial class MasterData31 : MasterDataBase    { }
    public partial class MasterData32 : MasterDataBase    { }
    public partial class MasterData33 : MasterDataBase    { }
    public partial class MasterData34 : MasterDataBase    { }
    public partial class MasterData35 : MasterDataBase    { }
    public partial class MasterData36 : MasterDataBase    { }
    public partial class MasterData37 : MasterDataBase    { }
    public partial class MasterData38 : MasterDataBase    { }
    public partial class MasterData39 : MasterDataBase    { }

    public partial class MasterData40 : MasterDataBase    { }
    public partial class MasterData41 : MasterDataBase    { }
    public partial class MasterData42 : MasterDataBase    { }
    public partial class MasterData43 : MasterDataBase    { }
    public partial class MasterData44 : MasterDataBase    { }
    public partial class MasterData45 : MasterDataBase    { }
    public partial class MasterData46 : MasterDataBase    { }
    public partial class MasterData47 : MasterDataBase    { }
    public partial class MasterData48 : MasterDataBase    { }
    public partial class MasterData49 : MasterDataBase    { }

    public partial class MasterData50 : MasterDataBase    { }
    public partial class MasterData51 : MasterDataBase    { }
    public partial class MasterData52 : MasterDataBase    { }
    public partial class MasterData53 : MasterDataBase    { }
    public partial class MasterData54 : MasterDataBase    { }
    public partial class MasterData55 : MasterDataBase    { }
    public partial class MasterData56 : MasterDataBase    { }
    public partial class MasterData57 : MasterDataBase    { }
    public partial class MasterData58 : MasterDataBase    { }
    public partial class MasterData59 : MasterDataBase    { }

    public partial class MasterData60 : MasterDataBase    { }
    public partial class MasterData61 : MasterDataBase    { }
    public partial class MasterData62 : MasterDataBase    { }
    public partial class MasterData63 : MasterDataBase    { }
    public partial class MasterData64 : MasterDataBase    { }
    public partial class MasterData65 : MasterDataBase    { }
    public partial class MasterData66 : MasterDataBase    { }
    public partial class MasterData67 : MasterDataBase    { }
    public partial class MasterData68 : MasterDataBase    { }
    public partial class MasterData69 : MasterDataBase    { }

    public partial class MasterData70 : MasterDataBase    { }
    public partial class MasterData71 : MasterDataBase    { }
    public partial class MasterData72 : MasterDataBase    { }
    public partial class MasterData73 : MasterDataBase    { }
    public partial class MasterData74 : MasterDataBase    { }
    public partial class MasterData75 : MasterDataBase    { }
    public partial class MasterData76 : MasterDataBase    { }
    public partial class MasterData77 : MasterDataBase    { }
    public partial class MasterData78 : MasterDataBase    { }
    public partial class MasterData79 : MasterDataBase    { }
}
