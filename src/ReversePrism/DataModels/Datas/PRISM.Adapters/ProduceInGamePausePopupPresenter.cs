using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865ED680 ModelClassType IProduceInGamePausePopupView IProduceInGamePausePopupView IProduceInGamePausePopupView Pointer
    // 018 ViewModel                                00018655AAA0 ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer
    // 020 EnemySkillDetailPopupViewModels          000185D14268 ModelClassListType IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> List<ProduceEnemySkillDetailPopupViewModel> Pointer
    // 028 onApplyProduceOptionSubject              Subject`1<ProduceOptionSaveData> IL2CPP_TYPE_GENERICINST
    // 030 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ProduceInGamePausePopupPresenter
    {
        public IProduceInGamePausePopupView?            View                                    { get; set; }
        public ProduceInGamePausePopupViewModel?        ViewModel                               { get; set; }
        public List<ProduceEnemySkillDetailPopupViewModel>? EnemySkillDetailPopupViewModels         { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static ProduceInGamePausePopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupPresenter();

            value.View                                      = GetObject<IProduceInGamePausePopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceInGamePausePopupView.FromPointer); // 0270D64D7428 0x10 View                        ( 0001865ED680 ModelClassType IProduceInGamePausePopupView IProduceInGamePausePopupView IProduceInGamePausePopupView Pointer )
            value.ViewModel                                 = GetObject<ProduceInGamePausePopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceInGamePausePopupViewModel.FromPointer); // 0270D64D7448 0x18 ViewModel                   ( 00018655AAA0 ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer )
            value.EnemySkillDetailPopupViewModels           = GetObjectList<ProduceEnemySkillDetailPopupViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceEnemySkillDetailPopupViewModel.FromPointer); // 0270D64D7468 0x20 EnemySkillDetailPopupViewModels ( 000185D14268 ModelClassListType IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> IReadOnlyList`1<ProduceEnemySkillDetailPopupViewModel> List<ProduceEnemySkillDetailPopupViewModel> Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D64D74A8 0x30 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D64D74C8 0x38 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
