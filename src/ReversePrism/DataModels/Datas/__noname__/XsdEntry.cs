using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelEnumType Token Token Token Int32
    // 014 CurrentState                             ModelEnumType State State State Int32
    // 018 NextStates                               ModelEnumListType State[] State[] List<State> Pointer
    // 020 Attributes                               ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 028 InitFunc                                 ModelClassType XsdInitFunction XsdInitFunction XsdInitFunction Pointer
    // 030 EndChildFunc                             ModelClassType XsdEndChildFunction XsdEndChildFunction XsdEndChildFunction Pointer
    // 038 ParseContent                             ModelPrimitiveType bool bool bool Bool
    public partial class XsdEntry : DataModel
    {
        public Token                                    Name                                    { get; set; }
        public State                                    CurrentState                            { get; set; }
        public List<State>?                             NextStates                              { get; set; }
        public List<XsdAttributeEntry>?                 Attributes                              { get; set; }
        public XsdInitFunction?                         InitFunc                                { get; set; }
        public XsdEndChildFunction?                     EndChildFunc                            { get; set; }
        public bool                                     ParseContent                            { get; set; }

        public static XsdEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdEntry() { Pointer= p0 };

            value.Name                                      = (Token)GetInt32(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelEnumType Token Token Token Int32 )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x014)); // 0x14 CurrentState                ( ModelEnumType State State State Int32 )
            value.NextStates                                = GetEnumList<State>(new IntPtr(p + 0x018)); // 0x18 NextStates                  ( ModelEnumListType State[] State[] List<State> Pointer )
            value.Attributes                                = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x20 Attributes                  ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.InitFunc                                  = GetObject<XsdInitFunction>(new IntPtr(p + 0x028), ReversePrism.DataModels.XsdInitFunction.FromPointer); // 0x28 InitFunc                    ( ModelClassType XsdInitFunction XsdInitFunction XsdInitFunction Pointer )
            value.EndChildFunc                              = GetObject<XsdEndChildFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.XsdEndChildFunction.FromPointer); // 0x30 EndChildFunc                ( ModelClassType XsdEndChildFunction XsdEndChildFunction XsdEndChildFunction Pointer )
            value.ParseContent                              = GetBool(new IntPtr(p + 0x038)); // 0x38 ParseContent                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
