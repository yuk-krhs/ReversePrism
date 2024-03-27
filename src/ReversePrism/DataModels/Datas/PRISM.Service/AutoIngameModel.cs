using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseModel                                000186533F60 ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer
    // 018 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 IsRun                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 IsWin                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Cancellation                             00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class AutoIngameModel
    {
        public ProduceBaseModel?                        BaseModel                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public bool                                     IsRun                                   { get; set; }
        public bool                                     IsWin                                   { get; set; }
        public CancellationToken                        Cancellation                            { get; set; }

        public static AutoIngameModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoIngameModel();

            value.BaseModel                                 = GetObject<ProduceBaseModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceBaseModel.FromPointer); // 0270D6469830 0x10 BaseModel                   ( 000186533F60 ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6469850 0x18 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsRun                                     = GetBool(new IntPtr(p + 0x020)); // 0270D6469870 0x20 IsRun                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsWin                                     = GetBool(new IntPtr(p + 0x021)); // 0270D6469890 0x21 IsWin                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Cancellation                              = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0270D64698B0 0x28 Cancellation                ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
