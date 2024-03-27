using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_HardwareDynamicResRequested            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 m_AutoSizedRTs                           HashSet`1<RTHandle> IL2CPP_TYPE_GENERICINST
    // 020 M_AutoSizedRTsArray                      000185C9FA38 ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 028 m_ResizeOnDemandRTs                      HashSet`1<RTHandle> IL2CPP_TYPE_GENERICINST
    // 030 M_RTHandleProperties                     00018664C1D0 ModelEnumType RTHandleProperties RTHandleProperties RTHandleProperties Int32
    // 060 M_MaxWidths                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 M_MaxHeights                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RTHandleSystem
    {
        public bool                                     M_HardwareDynamicResRequested           { get; set; }
        public List<RTHandle>?                          M_AutoSizedRTsArray                     { get; set; }
        public RTHandleProperties                       M_RTHandleProperties                    { get; set; }
        public int                                      M_MaxWidths                             { get; set; }
        public int                                      M_MaxHeights                            { get; set; }

        public static RTHandleSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RTHandleSystem();

            value.M_HardwareDynamicResRequested             = GetBool(new IntPtr(p + 0x010)); // 0270D0AC6E28 0x10 M_HardwareDynamicResRequested ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_AutoSizedRTsArray                       = GetObjectList<RTHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.RTHandle.FromPointer); // 0270D0AC6E68 0x20 M_AutoSizedRTsArray         ( 000185C9FA38 ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_RTHandleProperties                      = (RTHandleProperties)GetInt32(new IntPtr(p + 0x030)); // 0270D0AC6EA8 0x30 M_RTHandleProperties        ( 00018664C1D0 ModelEnumType RTHandleProperties RTHandleProperties RTHandleProperties Int32 )
            value.M_MaxWidths                               = GetInt32(new IntPtr(p + 0x060)); // 0270D0AC6EC8 0x60 M_MaxWidths                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MaxHeights                              = GetInt32(new IntPtr(p + 0x064)); // 0270D0AC6EE8 0x64 M_MaxHeights                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
