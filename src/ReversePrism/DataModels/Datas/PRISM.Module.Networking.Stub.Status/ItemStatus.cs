using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExpireDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ItemIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 ItemId                                   000186671910 ModelPrimitiveType string string string String
    // 000 MstItemIdFieldNumber                     int IL2CPP_TYPE_I4
    // 030 MstItemId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 ItemNaviTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 040 ItemNaviType                             0001867404C0 ModelEnumType ItemNaviType ItemNaviType ItemNaviType Int32
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 044 Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MaxAmountFieldNumber                     int IL2CPP_TYPE_I4
    // 048 MaxAmount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ItemTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 04C ItemType                                 000186741AB0 ModelEnumType ItemType ItemType ItemType Int32
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 050 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 054 Value                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ExpireDateFieldNumber                    int IL2CPP_TYPE_I4
    // 058 _ExpireDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ExpireDateListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_expireDateList_codec           FieldCodec`1<Timestamp> IL2CPP_TYPE_GENERICINST
    // 060 ExpireDateList                           000185CF5058 ModelClassListType RepeatedField`1<Timestamp> RepeatedField`1<Timestamp> List<Timestamp> Pointer
    public partial class ItemStatus : DataModel
    {
        public DateTime                                 ExpireDate                              { get; set; }
        public string                                   ItemId                                  { get; set; }
        public int                                      MstItemId                               { get; set; }
        public string                                   Name                                    { get; set; }
        public ItemNaviType                             ItemNaviType                            { get; set; }
        public int                                      Amount                                  { get; set; }
        public int                                      MaxAmount                               { get; set; }
        public ItemType                                 ItemType                                { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      Value                                   { get; set; }
        public Timestamp?                               _ExpireDate                             { get; set; }
        public List<Timestamp>?                         ExpireDateList                          { get; set; }

        public static ItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemStatus() { Pointer= p0 };

            value.ExpireDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0246637E7898 0x10 ExpireDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ItemId                                    = GetString(new IntPtr(p + 0x028)); // 0246637E7918 0x28 ItemId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.MstItemId                                 = GetInt32(new IntPtr(p + 0x030)); // 0246637E7958 0x30 MstItemId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x038)); // 0246637E7998 0x38 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ItemNaviType                              = (ItemNaviType)GetInt32(new IntPtr(p + 0x040)); // 0246637E79D8 0x40 ItemNaviType                ( 0001867404C0 ModelEnumType ItemNaviType ItemNaviType ItemNaviType Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x044)); // 0246637E7A18 0x44 Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxAmount                                 = GetInt32(new IntPtr(p + 0x048)); // 0246637E7A58 0x48 MaxAmount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ItemType                                  = (ItemType)GetInt32(new IntPtr(p + 0x04C)); // 0246637E7A98 0x4C ItemType                    ( 000186741AB0 ModelEnumType ItemType ItemType ItemType Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x050)); // 0246637E7AD8 0x50 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x054)); // 0246637E7B18 0x54 Value                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._ExpireDate                               = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0246637E7B58 0x58 _ExpireDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ExpireDateList                            = GetObjectList<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0246637E7BB8 0x60 ExpireDateList              ( 000185CF5058 ModelClassListType RepeatedField`1<Timestamp> RepeatedField`1<Timestamp> List<Timestamp> Pointer )
            value.ExpireDate                    = ToDateTime(value._ExpireDate);

            return value;
        }
    }
}
