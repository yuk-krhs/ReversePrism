using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameter                                0001867723C0 ModelEnumType Parameter Parameter Parameter Int32
    // 03C Type                                     00018654CB70 ModelEnumType ReactType ReactType ReactType Int32
    // 040 EnablePausingCue                         000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ReactParameter
    {
        public Parameter                                Parameter                               { get; set; }
        public ReactType                                Type                                    { get; set; }
        public bool                                     EnablePausingCue                        { get; set; }

        public static ReactParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReactParameter();

            value.Parameter                                 = (Parameter)GetInt32(new IntPtr(p + 0x010)); // 0270DAC6E8B0 0x10 Parameter                   ( 0001867723C0 ModelEnumType Parameter Parameter Parameter Int32 )
            value.Type                                      = (ReactType)GetInt32(new IntPtr(p + 0x03C)); // 0270DAC6E8D0 0x3C Type                        ( 00018654CB70 ModelEnumType ReactType ReactType ReactType Int32 )
            value.EnablePausingCue                          = GetBool(new IntPtr(p + 0x040)); // 0270DAC6E8F0 0x40 EnablePausingCue            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
