using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865E61F0 ModelClassType IProduceEnemySkillDetailPopupView IProduceEnemySkillDetailPopupView IProduceEnemySkillDetailPopupView Pointer
    // 018 ViewModel                                00018653DAE0 ModelClassType ProduceEnemySkillDetailPopupViewModel ProduceEnemySkillDetailPopupViewModel ProduceEnemySkillDetailPopupViewModel Pointer
    // 020 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceEnemySkillDetailPopupPresenter : DataModel
    {
        public IProduceEnemySkillDetailPopupView?       View                                    { get; set; }
        public ProduceEnemySkillDetailPopupViewModel?   ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ProduceEnemySkillDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceEnemySkillDetailPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceEnemySkillDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceEnemySkillDetailPopupView.FromPointer); // 0246664FB650 0x10 View                        ( 0001865E61F0 ModelClassType IProduceEnemySkillDetailPopupView IProduceEnemySkillDetailPopupView IProduceEnemySkillDetailPopupView Pointer )
            value.ViewModel                                 = GetObject<ProduceEnemySkillDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceEnemySkillDetailPopupViewModel.FromPointer); // 0246664FB670 0x18 ViewModel                   ( 00018653DAE0 ModelClassType ProduceEnemySkillDetailPopupViewModel ProduceEnemySkillDetailPopupViewModel ProduceEnemySkillDetailPopupViewModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246664FB690 0x20 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
