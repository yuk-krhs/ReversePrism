using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Completed1Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed2Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed3Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed4Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed5Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed6Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed7Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed8Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed9Delegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed10Delegate                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed11Delegate                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed12Delegate                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed13Delegate                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed14Delegate                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 Completed15Delegate                      Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 CompleteCount                            int IL2CPP_TYPE_I4
    // 000 source1                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source2                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source3                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source4                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source5                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source6                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source7                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source8                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source9                                  IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source10                                 IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source11                                 IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source12                                 IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source13                                 IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source14                                 IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 source15                                 IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 resultSelector                           Func`16<<var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 enumerator1                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter1                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent1                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running1                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current1                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator2                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter2                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent2                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running2                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current2                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator3                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter3                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent3                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running3                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current3                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator4                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter4                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent4                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running4                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current4                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator5                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter5                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent5                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running5                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current5                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator6                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter6                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent6                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running6                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current6                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator7                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter7                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent7                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running7                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current7                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator8                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter8                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent8                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running8                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current8                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator9                              IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter9                                 Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent9                              bool IL2CPP_TYPE_BOOLEAN
    // 000 running9                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 current9                                 <var> IL2CPP_TYPE_VAR
    // 000 enumerator10                             IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter10                                Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent10                             bool IL2CPP_TYPE_BOOLEAN
    // 000 running10                                bool IL2CPP_TYPE_BOOLEAN
    // 000 current10                                <var> IL2CPP_TYPE_VAR
    // 000 enumerator11                             IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter11                                Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent11                             bool IL2CPP_TYPE_BOOLEAN
    // 000 running11                                bool IL2CPP_TYPE_BOOLEAN
    // 000 current11                                <var> IL2CPP_TYPE_VAR
    // 000 enumerator12                             IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter12                                Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent12                             bool IL2CPP_TYPE_BOOLEAN
    // 000 running12                                bool IL2CPP_TYPE_BOOLEAN
    // 000 current12                                <var> IL2CPP_TYPE_VAR
    // 000 enumerator13                             IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter13                                Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent13                             bool IL2CPP_TYPE_BOOLEAN
    // 000 running13                                bool IL2CPP_TYPE_BOOLEAN
    // 000 current13                                <var> IL2CPP_TYPE_VAR
    // 000 enumerator14                             IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter14                                Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent14                             bool IL2CPP_TYPE_BOOLEAN
    // 000 running14                                bool IL2CPP_TYPE_BOOLEAN
    // 000 current14                                <var> IL2CPP_TYPE_VAR
    // 000 enumerator15                             IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter15                                Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 hasCurrent15                             bool IL2CPP_TYPE_BOOLEAN
    // 000 running15                                bool IL2CPP_TYPE_BOOLEAN
    // 000 current15                                <var> IL2CPP_TYPE_VAR
    // 000 completedCount                           int IL2CPP_TYPE_I4
    // 000 syncRunning                              bool IL2CPP_TYPE_BOOLEAN
    // 000 result                                   <var> IL2CPP_TYPE_VAR
    public partial class _CombineLatest : DataModel
    {

        public static _CombineLatest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _CombineLatest() { Pointer= p0 };


            return value;
        }
    }
}
