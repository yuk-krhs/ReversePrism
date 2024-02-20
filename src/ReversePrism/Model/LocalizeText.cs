using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReversePrism
{
    // localizetext.bytes
    public class LocalizeText
    {
        public const string             HexChars    = "0123456789ABCDEF";

        public string?                  FileName                { get; set; }
        public int                      Count                   { get; set; }
        public List<MasterGroup>        Groups                  { get; set; } = new List<MasterGroup>();
        public Dictionary<string, MasterGroup> GroupMap         { get; set; } = new Dictionary<string, MasterGroup>();
        public MasterGroup              this[string group]      => GroupMap[group];
        public string                   this[string group, int id] => GroupMap[group].ItemMap[id].Text;

        public static string GetRealName(CatalogASet catalog)
        {
            var label   = CatalogDB.CalcResourceLabel("localizetext.bytes");

            if(!catalog.TryGetValue(label, out var rec))
                throw new InvalidDataException();

            var real    = CatalogDB.GetRealName(rec);

            return real;
        }

        public void ExportToJson(string file)
        {
            var list= new List<string>();

            foreach(var i in Groups)
            {
                list.Add(
                    $"{{{Environment.NewLine}"+
                    $"    \"GroupName\": \"{EscapeJsonString(i.Name)}\",{Environment.NewLine}"+
                    $"    \"Items\": [{Environment.NewLine}      "+
                    string.Join($",{Environment.NewLine}      ", i.Items.Select(j => j.ToJsonString()))+
                    $"{Environment.NewLine}    ]{Environment.NewLine}"+
                    $"  }}");
            }

            File.WriteAllText(file,
                $"[{Environment.NewLine}  "+
                string.Join($",{Environment.NewLine}  ", list)+
                $"{Environment.NewLine}]");
        }

        private void Load(BinaryReader r)
        {
            Count       = r.ReadInt32();
            Groups      = Enumerable.Range(0, Count).Select(i => ReadGroup(r)).ToList();
            GroupMap    = Groups.ToDictionary(i => i.Name);
        }

        private MasterGroup ReadGroup(BinaryReader r)
        {
            var group   = new MasterGroup();
            group.Length= r.ReadInt32();
            group.Name  = Encoding.Unicode.GetString(r.ReadBytes(group.Length * 2));
            group.Count = r.ReadInt32();
            group.Items = Enumerable.Range(0, group.Count).Select(i => ReadItem(r)).ToList();
            group.ItemMap= group.Items.ToDictionary(i => i.Id);

            return group;
        }

        private MasterItem ReadItem(BinaryReader r)
        {
            var item    = new MasterItem();
            item.Id     = r.ReadInt32();
            item.Length = r.ReadInt32();
            item.Text   = Encoding.Unicode.GetString(r.ReadBytes(item.Length * 2));

            return item;
        }

        public static string EscapeJsonString(string? s)
            => s == null ? throw new ArgumentException(nameof(s))
                : new string(EscapeJsonStringInternal(s).ToArray());

        public static IEnumerable<char> EscapeJsonStringInternal(string s)
        {
            foreach(var i in s)
            {
                if((i >= 0x20 && i <= 0x7E) || i >= 0x80)
                {
                    yield return i;
                    continue;
                }

                switch(i)
                {
                case '\r':  yield return '\\'; yield return 'n';  break;
                case '\n':  yield return '\\'; yield return 'r';  break;
                case '\t':  yield return '\\'; yield return 't';  break;
                case '\\':  yield return '\\'; yield return '\\'; break;
                default:    yield return '\\'; yield return 'x';
                            yield return HexChars[(i >> 4) & 0xF];
                            yield return HexChars[(i >> 0) & 0xF];
                    break;
                }
            }
        }


        public static LocalizeText FromPackedFile(string file, long label, long encrypt)
        {
            var packfile= PackedFile.FromEncryptedFile(file, label, encrypt);
            var value   = FromBytes(packfile.Data);

            value.FileName  = file;

            return value;
        }

        public static LocalizeText FromFile(string file)
        {
            using(var s= File.OpenRead(file))
                return FromStream(s);
        }

        public static LocalizeText FromBytes(byte[] data)
        {
            using(var s= new MemoryStream(data))
                return FromStream(s);
        }

        public static LocalizeText FromStream(Stream s, bool leaveOpen = true)
        {
            using(var r= new BinaryReader(s, Encoding.Unicode, leaveOpen))
            {
                var value   = new LocalizeText() { FileName= (s as FileStream)?.Name };

                value.Load(r);

                return value;
            }
        }
    }

    public class MasterGroup : IEnumerable<(int Id, string Text)>
    {
        public int                      Length                  { get; set; }
        public string                   Name                    { get; set; } = "";
        public int                      Count                   { get; set; }
        public List<MasterItem>         Items                   { get; set; } = new List<MasterItem>();
        public Dictionary<int, MasterItem> ItemMap              { get; set; } = new Dictionary<int, MasterItem>();

        public IEnumerator<(int Id, string Text)> GetEnumerator()
            => ItemMap.Values.Select(i => (i.Id, i.Text)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class MasterItem
    {
        public int                      Id                      { get; set; }
        public int                      Length                  { get; set; }
        public string?                  Text                    { get; set; }

        public string ToJsonString()
            => $"{{ \"Id\": {Id}, \"Text\": \"{LocalizeText.EscapeJsonString(Text)}\" }}";
    }
}
