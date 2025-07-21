using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Path                                     ModelPrimitiveType string string string String
    // 048 Bytes                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 Phase                                    ModelEnumType Phase Phase Phase Int32
    // 058 RefBinder                                ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer
    // 060 NewBinder                                ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer
    // 068 BindId                                   ModelPrimitiveType uint uint uint UInt32
    // 070 Loader                                   ModelClassType CriFsLoader CriFsLoader CriFsLoader Pointer
    // 078 ReadUnitSize                             ModelPrimitiveType int int int Int32
    // 080 FileSize                                 ModelPrimitiveType long long long Int64
    public partial class CriFsLoadFileRequest : DataModel
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
            var value   = new CriFsLoadFileRequest() { Pointer= p0 };

            value.Path                                      = GetString(new IntPtr(p + 0x040)); // 0x40 Path                        ( ModelPrimitiveType string string string String )
            value.Bytes                                     = GetSByteList(new IntPtr(p + 0x048)); // 0x48 Bytes                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Phase                                     = (Phase)GetInt32(new IntPtr(p + 0x050)); // 0x50 Phase                       ( ModelEnumType Phase Phase Phase Int32 )
            value.RefBinder                                 = GetObject<CriFsBinder>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriFsBinder.FromPointer); // 0x58 RefBinder                   ( ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer )
            value.NewBinder                                 = GetObject<CriFsBinder>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriFsBinder.FromPointer); // 0x60 NewBinder                   ( ModelClassType CriFsBinder CriFsBinder CriFsBinder Pointer )
            value.BindId                                    = GetUInt32(new IntPtr(p + 0x068)); // 0x68 BindId                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.Loader                                    = GetObject<CriFsLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.CriFsLoader.FromPointer); // 0x70 Loader                      ( ModelClassType CriFsLoader CriFsLoader CriFsLoader Pointer )
            value.ReadUnitSize                              = GetInt32(new IntPtr(p + 0x078)); // 0x78 ReadUnitSize                ( ModelPrimitiveType int int int Int32 )
            value.FileSize                                  = GetInt64(new IntPtr(p + 0x080)); // 0x80 FileSize                    ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
