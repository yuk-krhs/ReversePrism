using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_standardDrawers                        000185B8D230 ModelClassListType InspectorField[] InspectorField[] List<InspectorField> Pointer
    // 020 M_referenceDrawers                       000185B8D230 ModelClassListType InspectorField[] InspectorField[] List<InspectorField> Pointer
    // 028 M_hiddenVariables                        000185CB03D8 ModelClassListType VariableSet[] VariableSet[] List<VariableSet> Pointer
    // 030 M_exposedVariables                       000185CB03D8 ModelClassListType VariableSet[] VariableSet[] List<VariableSet> Pointer
    public partial class RuntimeInspectorSettings
    {
        public List<InspectorField>?                    M_standardDrawers                       { get; set; }
        public List<InspectorField>?                    M_referenceDrawers                      { get; set; }
        public List<VariableSet>?                       M_hiddenVariables                       { get; set; }
        public List<VariableSet>?                       M_exposedVariables                      { get; set; }

        public static RuntimeInspectorSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInspectorSettings();

            value.M_standardDrawers                         = GetObjectList<InspectorField>(new IntPtr(p + 0x018), ReversePrism.DataModels.InspectorField.FromPointer); // 0270DB1B99E0 0x18 M_standardDrawers           ( 000185B8D230 ModelClassListType InspectorField[] InspectorField[] List<InspectorField> Pointer )
            value.M_referenceDrawers                        = GetObjectList<InspectorField>(new IntPtr(p + 0x020), ReversePrism.DataModels.InspectorField.FromPointer); // 0270DB1B9A00 0x20 M_referenceDrawers          ( 000185B8D230 ModelClassListType InspectorField[] InspectorField[] List<InspectorField> Pointer )
            value.M_hiddenVariables                         = GetObjectList<VariableSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.VariableSet.FromPointer); // 0270DB1B9A20 0x28 M_hiddenVariables           ( 000185CB03D8 ModelClassListType VariableSet[] VariableSet[] List<VariableSet> Pointer )
            value.M_exposedVariables                        = GetObjectList<VariableSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.VariableSet.FromPointer); // 0270DB1B9A40 0x30 M_exposedVariables          ( 000185CB03D8 ModelClassListType VariableSet[] VariableSet[] List<VariableSet> Pointer )

            return value;
        }
    }
}
