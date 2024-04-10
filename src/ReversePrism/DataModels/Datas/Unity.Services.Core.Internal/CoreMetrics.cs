using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PackageInitTimeMetricName                string IL2CPP_TYPE_STRING
    // 000 AllPackagesInitSuccessMetricName         string IL2CPP_TYPE_STRING
    // 000 AllPackagesInitTimeMetricName            string IL2CPP_TYPE_STRING
    // 000 PackageInitializerNamesKeyFormat         string IL2CPP_TYPE_STRING
    // 000 PackageInitializerNamesSeparator         char IL2CPP_TYPE_CHAR
    // 000 AllPackageNamesKey                       string IL2CPP_TYPE_STRING
    // 000 AllPackageNamesSeparator                 char IL2CPP_TYPE_CHAR
    // 000 <Instance>k__BackingField                CoreMetrics IL2CPP_TYPE_CLASS
    // 010 Metrics                                  0001865B2F70 ModelClassType IMetrics IMetrics IMetrics Pointer
    // 018 <AllPackageMetrics>k__BackingField       IDictionary`2<Type, IMetrics> IL2CPP_TYPE_GENERICINST
    public partial class CoreMetrics : DataModel
    {
        public IMetrics?                                Metrics                                 { get; set; }

        public static CoreMetrics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreMetrics() { Pointer= p0 };

            value.Metrics                                   = GetObject<IMetrics>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMetrics.FromPointer); // 0246608BDEE0 0x10 Metrics                     ( 0001865B2F70 ModelClassType IMetrics IMetrics IMetrics Pointer )

            return value;
        }
    }
}
