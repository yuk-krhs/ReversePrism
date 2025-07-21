using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Handle                                   ModelEnumType GCHandle GCHandle GCHandle Int32
    // 028 instance                                 <int> IL2CPP_TYPE_I
    // 030 ReadFunc                                 ModelClassType BioReadFunc BioReadFunc BioReadFunc Pointer
    // 038 WriteFunc                                ModelClassType BioWriteFunc BioWriteFunc BioWriteFunc Pointer
    // 040 ControlFunc                              ModelClassType BioControlFunc BioControlFunc BioControlFunc Pointer
    // 048 readFuncPtr                              <int> IL2CPP_TYPE_I
    // 050 writeFuncPtr                             <int> IL2CPP_TYPE_I
    // 058 controlFuncPtr                           <int> IL2CPP_TYPE_I
    // 060 Backend                                  ModelClassType IMonoBtlsBioMono IMonoBtlsBioMono IMonoBtlsBioMono Pointer
    public partial class MonoBtlsBioMono : DataModel
    {
        public GCHandle                                 Handle                                  { get; set; }
        public BioReadFunc?                             ReadFunc                                { get; set; }
        public BioWriteFunc?                            WriteFunc                               { get; set; }
        public BioControlFunc?                          ControlFunc                             { get; set; }
        public IMonoBtlsBioMono?                        Backend                                 { get; set; }

        public static MonoBtlsBioMono? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsBioMono() { Pointer= p0 };

            value.Handle                                    = (GCHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 Handle                      ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.ReadFunc                                  = GetObject<BioReadFunc>(new IntPtr(p + 0x030), ReversePrism.DataModels.BioReadFunc.FromPointer); // 0x30 ReadFunc                    ( ModelClassType BioReadFunc BioReadFunc BioReadFunc Pointer )
            value.WriteFunc                                 = GetObject<BioWriteFunc>(new IntPtr(p + 0x038), ReversePrism.DataModels.BioWriteFunc.FromPointer); // 0x38 WriteFunc                   ( ModelClassType BioWriteFunc BioWriteFunc BioWriteFunc Pointer )
            value.ControlFunc                               = GetObject<BioControlFunc>(new IntPtr(p + 0x040), ReversePrism.DataModels.BioControlFunc.FromPointer); // 0x40 ControlFunc                 ( ModelClassType BioControlFunc BioControlFunc BioControlFunc Pointer )
            value.Backend                                   = GetObject<IMonoBtlsBioMono>(new IntPtr(p + 0x060), ReversePrism.DataModels.IMonoBtlsBioMono.FromPointer); // 0x60 Backend                     ( ModelClassType IMonoBtlsBioMono IMonoBtlsBioMono IMonoBtlsBioMono Pointer )

            return value;
        }
    }
}
