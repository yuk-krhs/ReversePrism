using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_24Fps                                  FrameRate IL2CPP_TYPE_VALUETYPE
    // 004 k_23_976Fps                              FrameRate IL2CPP_TYPE_VALUETYPE
    // 008 k_25Fps                                  FrameRate IL2CPP_TYPE_VALUETYPE
    // 00C k_30Fps                                  FrameRate IL2CPP_TYPE_VALUETYPE
    // 010 K_29_97Fps                               0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32
    // 014 K_50Fps                                  0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32
    // 018 K_60Fps                                  0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32
    // 01C K_59_94Fps                               0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32
    // 010 M_Rate                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FrameRate
    {
        public FrameRate                                K_29_97Fps                              { get; set; }
        public FrameRate                                K_50Fps                                 { get; set; }
        public FrameRate                                K_60Fps                                 { get; set; }
        public FrameRate                                K_59_94Fps                              { get; set; }
        public int                                      M_Rate                                  { get; set; }

        public static FrameRate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameRate();

            value.K_29_97Fps                                = (FrameRate)GetInt32(new IntPtr(p + 0x010)); // 0270023F0600 0x10 K_29_97Fps                  ( 0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32 )
            value.K_50Fps                                   = (FrameRate)GetInt32(new IntPtr(p + 0x014)); // 0270023F0620 0x14 K_50Fps                     ( 0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32 )
            value.K_60Fps                                   = (FrameRate)GetInt32(new IntPtr(p + 0x018)); // 0270023F0640 0x18 K_60Fps                     ( 0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32 )
            value.K_59_94Fps                                = (FrameRate)GetInt32(new IntPtr(p + 0x01C)); // 0270023F0660 0x1C K_59_94Fps                  ( 0001865D5D80 ModelEnumType FrameRate FrameRate FrameRate Int32 )
            value.M_Rate                                    = GetInt32(new IntPtr(p + 0x010)); // 0270023F0680 0x10 M_Rate                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
