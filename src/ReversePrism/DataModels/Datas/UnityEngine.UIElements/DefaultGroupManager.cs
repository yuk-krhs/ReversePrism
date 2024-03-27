using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GroupOptions                           000185CE4918 ModelClassListType List`1<IGroupBoxOption> List`1<IGroupBoxOption> List<IGroupBoxOption> Pointer
    // 018 M_SelectedOption                         0001865631B0 ModelClassType IGroupBoxOption IGroupBoxOption IGroupBoxOption Pointer
    // 020 M_GroupBox                               000186562CD0 ModelClassType IGroupBox IGroupBox IGroupBox Pointer
    public partial class DefaultGroupManager
    {
        public List<IGroupBoxOption>?                   M_GroupOptions                          { get; set; }
        public IGroupBoxOption?                         M_SelectedOption                        { get; set; }
        public IGroupBox?                               M_GroupBox                              { get; set; }

        public static DefaultGroupManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultGroupManager();

            value.M_GroupOptions                            = GetObjectList<IGroupBoxOption>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGroupBoxOption.FromPointer); // 0270067DD310 0x10 M_GroupOptions              ( 000185CE4918 ModelClassListType List`1<IGroupBoxOption> List`1<IGroupBoxOption> List<IGroupBoxOption> Pointer )
            value.M_SelectedOption                          = GetObject<IGroupBoxOption>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGroupBoxOption.FromPointer); // 0270067DD330 0x18 M_SelectedOption            ( 0001865631B0 ModelClassType IGroupBoxOption IGroupBoxOption IGroupBoxOption Pointer )
            value.M_GroupBox                                = GetObject<IGroupBox>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGroupBox.FromPointer); // 0270067DD350 0x20 M_GroupBox                  ( 000186562CD0 ModelClassType IGroupBox IGroupBox IGroupBox Pointer )

            return value;
        }
    }
}
