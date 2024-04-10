using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Sequence                                 000186591B30 ModelClassType ProduceTutorialSequenceBase ProduceTutorialSequenceBase ProduceTutorialSequenceBase Pointer
    // 020 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 InputBlockCouct                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C ShowTextCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 ShowFadeCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 InputBlockDragCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Disposables                              0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 024665DC09B0 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Sequence                                  = GetObject<ProduceTutorialSequenceBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceTutorialSequenceBase.FromPointer); // 024665DC09D0 0x18 Sequence                    ( 000186591B30 ModelClassType ProduceTutorialSequenceBase ProduceTutorialSequenceBase ProduceTutorialSequenceBase Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665DC09F0 0x20 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.InputBlockCouct                           = GetInt32(new IntPtr(p + 0x028)); // 024665DC0A10 0x28 InputBlockCouct             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ShowTextCount                             = GetInt32(new IntPtr(p + 0x02C)); // 024665DC0A30 0x2C ShowTextCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ShowFadeCount                             = GetInt32(new IntPtr(p + 0x030)); // 024665DC0A50 0x30 ShowFadeCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InputBlockDragCount                       = GetInt32(new IntPtr(p + 0x034)); // 024665DC0A70 0x34 InputBlockDragCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665DC0A90 0x38 Disposables                 ( 0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
