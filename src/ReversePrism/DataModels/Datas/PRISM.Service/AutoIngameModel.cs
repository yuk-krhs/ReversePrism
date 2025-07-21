using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseModel                                ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer
    // 018 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 IsRun                                    ModelPrimitiveType bool bool bool Bool
    // 021 IsWin                                    ModelPrimitiveType bool bool bool Bool
    // 028 Cancellation                             ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class AutoIngameModel : DataModel
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
            var value   = new AutoIngameModel() { Pointer= p0 };

            value.BaseModel                                 = GetObject<ProduceBaseModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceBaseModel.FromPointer); // 0x10 BaseModel                   ( ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsRun                                     = GetBool(new IntPtr(p + 0x020)); // 0x20 IsRun                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsWin                                     = GetBool(new IntPtr(p + 0x021)); // 0x21 IsWin                       ( ModelPrimitiveType bool bool bool Bool )
            value.Cancellation                              = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 Cancellation                ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
