using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Path                                     000186671910 ModelPrimitiveType string string string String
    // 048 Bytes                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Phase                                    00018655AD20 ModelEnumType Phase Phase Phase Int32
    // 058 RefBinder                                000186650280 ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer
    // 060 NewBinder                                000186650280 ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer
    // 068 BindId                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 070 Loader                                   000186652240 ModelClassType CriFsLoader CriFsLoader CriFsLoader Pointer
    // 078 ReadUnitSize                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 FileSize                                 0001865F7700 ModelPrimitiveType long long long Int64
    public partial class CriFsLoadFileRequest
    {
        public string                                   Path                                    { get; set; }
        public List<sbyte>?                             Bytes                                   { get; set; }
        public Phase                                    Phase                                   { get; set; }
        public CriFsBinder?                             RefBinder                               { get; set; }
        public CriFsBinder?                             NewBinder                               { get; set; }
        public uint                                     BindId                                  { get; set; }
        public CriFsLoader?                             Loader                                  { get; set; }
        public int                                      ReadUnitSize                            { get; set; }
        public long                                     FileSize                                { get; set; }

        public static CriFsLoadFileRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsLoadFileRequest();

            value.Path                                      = GetString(new IntPtr(p + 0x040)); // 0270DACB5D10 0x40 Path                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Bytes                                     = GetSByteList(new IntPtr(p + 0x048)); // 0270DACB5D30 0x48 Bytes                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Phase                                     = (Phase)GetInt32(new IntPtr(p + 0x050)); // 0270DACB5D50 0x50 Phase                       ( 00018655AD20 ModelEnumType Phase Phase Phase Int32 )
            value.RefBinder                                 = GetObject<CriFsBinder>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriFsBinder.FromPointer); // 0270DACB5D70 0x58 RefBinder                   ( 000186650280 ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer )
            value.NewBinder                                 = GetObject<CriFsBinder>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriFsBinder.FromPointer); // 0270DACB5D90 0x60 NewBinder                   ( 000186650280 ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer )
            value.BindId                                    = GetUInt32(new IntPtr(p + 0x068)); // 0270DACB5DB0 0x68 BindId                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Loader                                    = GetObject<CriFsLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.CriFsLoader.FromPointer); // 0270DACB5DD0 0x70 Loader                      ( 000186652240 ModelClassType CriFsLoader CriFsLoader CriFsLoader Pointer )
            value.ReadUnitSize                              = GetInt32(new IntPtr(p + 0x078)); // 0270DACB5DF0 0x78 ReadUnitSize                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FileSize                                  = GetInt64(new IntPtr(p + 0x080)); // 0270DACB5E10 0x80 FileSize                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
