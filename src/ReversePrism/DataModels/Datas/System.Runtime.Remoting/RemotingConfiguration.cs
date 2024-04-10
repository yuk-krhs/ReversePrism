using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 applicationID                            string IL2CPP_TYPE_STRING
    // 008 applicationName                          string IL2CPP_TYPE_STRING
    // 010 ProcessGuid                              000186672530 ModelPrimitiveType string string string String
    // 018 DefaultConfigRead                        000186595C30 ModelPrimitiveType bool bool bool Bool
    // 019 DefaultDelayedConfigRead                 000186595C30 ModelPrimitiveType bool bool bool Bool
    // 01C ErrorMode                                00018666AED0 ModelEnumType CustomErrorsModes CustomErrorsModes CustomErrorsModes Int32
    // 020 WellKnownClientEntries                   0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 ActivatedClientEntries                   0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 WellKnownServiceEntries                  0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 ActivatedServiceEntries                  0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 ChannelTemplates                         0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 ClientProviderTemplates                  0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 ServerProviderTemplates                  0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class RemotingConfiguration : DataModel
    {
        public string                                   ProcessGuid                             { get; set; }
        public bool                                     DefaultConfigRead                       { get; set; }
        public bool                                     DefaultDelayedConfigRead                { get; set; }
        public CustomErrorsModes                        ErrorMode                               { get; set; }
        public Hashtable?                               WellKnownClientEntries                  { get; set; }
        public Hashtable?                               ActivatedClientEntries                  { get; set; }
        public Hashtable?                               WellKnownServiceEntries                 { get; set; }
        public Hashtable?                               ActivatedServiceEntries                 { get; set; }
        public Hashtable?                               ChannelTemplates                        { get; set; }
        public Hashtable?                               ClientProviderTemplates                 { get; set; }
        public Hashtable?                               ServerProviderTemplates                 { get; set; }

        public static RemotingConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemotingConfiguration() { Pointer= p0 };

            value.ProcessGuid                               = GetString(new IntPtr(p + 0x010)); // 024666C2B920 0x10 ProcessGuid                 ( 000186672530 ModelPrimitiveType string string string String )
            value.DefaultConfigRead                         = GetBool(new IntPtr(p + 0x018)); // 024666C2B940 0x18 DefaultConfigRead           ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.DefaultDelayedConfigRead                  = GetBool(new IntPtr(p + 0x019)); // 024666C2B960 0x19 DefaultDelayedConfigRead    ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.ErrorMode                                 = (CustomErrorsModes)GetInt32(new IntPtr(p + 0x01C)); // 024666C2B980 0x1C ErrorMode                   ( 00018666AED0 ModelEnumType CustomErrorsModes CustomErrorsModes CustomErrorsModes Int32 )
            value.WellKnownClientEntries                    = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2B9A0 0x20 WellKnownClientEntries      ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ActivatedClientEntries                    = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2B9C0 0x28 ActivatedClientEntries      ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.WellKnownServiceEntries                   = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2B9E0 0x30 WellKnownServiceEntries     ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ActivatedServiceEntries                   = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2BA00 0x38 ActivatedServiceEntries     ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ChannelTemplates                          = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2BA20 0x40 ChannelTemplates            ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ClientProviderTemplates                   = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2BA40 0x48 ClientProviderTemplates     ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ServerProviderTemplates                   = GetObject<Hashtable>(new IntPtr(p + 0x050), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2BA60 0x50 ServerProviderTemplates     ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
