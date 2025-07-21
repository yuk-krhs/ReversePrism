using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Sequence                                 ModelClassType ProduceTutorialSequenceBase ProduceTutorialSequenceBase ProduceTutorialSequenceBase Pointer
    // 020 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 InputBlockCouct                          ModelPrimitiveType int int int Int32
    // 02C ShowTextCount                            ModelPrimitiveType int int int Int32
    // 030 ShowFadeCount                            ModelPrimitiveType int int int Int32
    // 034 InputBlockDragCount                      ModelPrimitiveType int int int Int32
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceTutorialModel : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public ProduceTutorialSequenceBase?             Sequence                                { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public int                                      InputBlockCouct                         { get; set; }
        public int                                      ShowTextCount                           { get; set; }
        public int                                      ShowFadeCount                           { get; set; }
        public int                                      InputBlockDragCount                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceTutorialModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialModel() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Sequence                                  = GetObject<ProduceTutorialSequenceBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceTutorialSequenceBase.FromPointer); // 0x18 Sequence                    ( ModelClassType ProduceTutorialSequenceBase ProduceTutorialSequenceBase ProduceTutorialSequenceBase Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.InputBlockCouct                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 InputBlockCouct             ( ModelPrimitiveType int int int Int32 )
            value.ShowTextCount                             = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ShowTextCount               ( ModelPrimitiveType int int int Int32 )
            value.ShowFadeCount                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 ShowFadeCount               ( ModelPrimitiveType int int int Int32 )
            value.InputBlockDragCount                       = GetInt32(new IntPtr(p + 0x034)); // 0x34 InputBlockDragCount         ( ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
