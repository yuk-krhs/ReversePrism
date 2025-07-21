using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UNITYTLS_INVALID_HANDLE                  ModelPrimitiveType ulong ulong ulong UInt64
    // 018 UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT    ModelEnumType unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange Int32
    // 020 Unitytls_errorstate_create               ModelClassType unitytls_errorstate_create_t unitytls_errorstate_create_t unitytls_errorstate_create_t Pointer
    // 028 Unitytls_errorstate_raise_error          ModelClassType unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t Pointer
    // 030 Unitytls_key_get_ref                     ModelClassType unitytls_key_get_ref_t unitytls_key_get_ref_t unitytls_key_get_ref_t Pointer
    // 038 Unitytls_key_parse_der                   ModelClassType unitytls_key_parse_der_t unitytls_key_parse_der_t unitytls_key_parse_der_t Pointer
    // 040 Unitytls_key_parse_pem                   ModelClassType unitytls_key_parse_pem_t unitytls_key_parse_pem_t unitytls_key_parse_pem_t Pointer
    // 048 Unitytls_key_free                        ModelClassType unitytls_key_free_t unitytls_key_free_t unitytls_key_free_t Pointer
    // 050 Unitytls_x509_export_der                 ModelClassType unitytls_x509_export_der_t unitytls_x509_export_der_t unitytls_x509_export_der_t Pointer
    // 058 Unitytls_x509list_get_ref                ModelClassType unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t Pointer
    // 060 Unitytls_x509list_get_x509               ModelClassType unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t Pointer
    // 068 Unitytls_x509list_create                 ModelClassType unitytls_x509list_create_t unitytls_x509list_create_t unitytls_x509list_create_t Pointer
    // 070 Unitytls_x509list_append                 ModelClassType unitytls_x509list_append_t unitytls_x509list_append_t unitytls_x509list_append_t Pointer
    // 078 Unitytls_x509list_append_der             ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer
    // 080 Unitytls_x509list_append_pem             ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer
    // 088 Unitytls_x509list_free                   ModelClassType unitytls_x509list_free_t unitytls_x509list_free_t unitytls_x509list_free_t Pointer
    // 090 Unitytls_x509verify_default_ca           ModelClassType unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t Pointer
    // 098 Unitytls_x509verify_explicit_ca          ModelClassType unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t Pointer
    // 0A0 Unitytls_tlsctx_create_server            ModelClassType unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t Pointer
    // 0A8 Unitytls_tlsctx_create_client            ModelClassType unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t Pointer
    // 0B0 Unitytls_tlsctx_server_require_client_authentication ModelClassType unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t Pointer
    // 0B8 Unitytls_tlsctx_set_certificate_callback ModelClassType unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t Pointer
    // 0C0 Unitytls_tlsctx_set_trace_callback       ModelClassType unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t Pointer
    // 0C8 Unitytls_tlsctx_set_x509verify_callback  ModelClassType unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t Pointer
    // 0D0 Unitytls_tlsctx_set_supported_ciphersuites ModelClassType unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t Pointer
    // 0D8 Unitytls_tlsctx_get_ciphersuite          ModelClassType unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t Pointer
    // 0E0 Unitytls_tlsctx_get_protocol             ModelClassType unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t Pointer
    // 0E8 Unitytls_tlsctx_process_handshake        ModelClassType unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t Pointer
    // 0F0 Unitytls_tlsctx_read                     ModelClassType unitytls_tlsctx_read_t unitytls_tlsctx_read_t unitytls_tlsctx_read_t Pointer
    // 0F8 Unitytls_tlsctx_write                    ModelClassType unitytls_tlsctx_write_t unitytls_tlsctx_write_t unitytls_tlsctx_write_t Pointer
    // 100 Unitytls_tlsctx_notify_close             ModelClassType unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t Pointer
    // 108 Unitytls_tlsctx_free                     ModelClassType unitytls_tlsctx_free_t unitytls_tlsctx_free_t unitytls_tlsctx_free_t Pointer
    // 110 Unitytls_random_generate_bytes           ModelClassType unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t Pointer
    public partial class unitytls_interface_struct : DataModel
    {
        public ulong                                    UNITYTLS_INVALID_HANDLE                 { get; set; }
        public unitytls_tlsctx_protocolrange            UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT   { get; set; }
        public unitytls_errorstate_create_t?            Unitytls_errorstate_create              { get; set; }
        public unitytls_errorstate_raise_error_t?       Unitytls_errorstate_raise_error         { get; set; }
        public unitytls_key_get_ref_t?                  Unitytls_key_get_ref                    { get; set; }
        public unitytls_key_parse_der_t?                Unitytls_key_parse_der                  { get; set; }
        public unitytls_key_parse_pem_t?                Unitytls_key_parse_pem                  { get; set; }
        public unitytls_key_free_t?                     Unitytls_key_free                       { get; set; }
        public unitytls_x509_export_der_t?              Unitytls_x509_export_der                { get; set; }
        public unitytls_x509list_get_ref_t?             Unitytls_x509list_get_ref               { get; set; }
        public unitytls_x509list_get_x509_t?            Unitytls_x509list_get_x509              { get; set; }
        public unitytls_x509list_create_t?              Unitytls_x509list_create                { get; set; }
        public unitytls_x509list_append_t?              Unitytls_x509list_append                { get; set; }
        public unitytls_x509list_append_der_t?          Unitytls_x509list_append_der            { get; set; }
        public unitytls_x509list_append_der_t?          Unitytls_x509list_append_pem            { get; set; }
        public unitytls_x509list_free_t?                Unitytls_x509list_free                  { get; set; }
        public unitytls_x509verify_default_ca_t?        Unitytls_x509verify_default_ca          { get; set; }
        public unitytls_x509verify_explicit_ca_t?       Unitytls_x509verify_explicit_ca         { get; set; }
        public unitytls_tlsctx_create_server_t?         Unitytls_tlsctx_create_server           { get; set; }
        public unitytls_tlsctx_create_client_t?         Unitytls_tlsctx_create_client           { get; set; }
        public unitytls_tlsctx_server_require_client_authentication_t? Unitytls_tlsctx_server_require_client_authentication { get; set; }
        public unitytls_tlsctx_set_certificate_callback_t? Unitytls_tlsctx_set_certificate_callback { get; set; }
        public unitytls_tlsctx_set_trace_callback_t?    Unitytls_tlsctx_set_trace_callback      { get; set; }
        public unitytls_tlsctx_set_x509verify_callback_t? Unitytls_tlsctx_set_x509verify_callback { get; set; }
        public unitytls_tlsctx_set_supported_ciphersuites_t? Unitytls_tlsctx_set_supported_ciphersuites { get; set; }
        public unitytls_tlsctx_get_ciphersuite_t?       Unitytls_tlsctx_get_ciphersuite         { get; set; }
        public unitytls_tlsctx_get_protocol_t?          Unitytls_tlsctx_get_protocol            { get; set; }
        public unitytls_tlsctx_process_handshake_t?     Unitytls_tlsctx_process_handshake       { get; set; }
        public unitytls_tlsctx_read_t?                  Unitytls_tlsctx_read                    { get; set; }
        public unitytls_tlsctx_write_t?                 Unitytls_tlsctx_write                   { get; set; }
        public unitytls_tlsctx_notify_close_t?          Unitytls_tlsctx_notify_close            { get; set; }
        public unitytls_tlsctx_free_t?                  Unitytls_tlsctx_free                    { get; set; }
        public unitytls_random_generate_bytes_t?        Unitytls_random_generate_bytes          { get; set; }

        public static unitytls_interface_struct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_interface_struct() { Pointer= p0 };

            value.UNITYTLS_INVALID_HANDLE                   = GetUInt64(new IntPtr(p + 0x010)); // 0x10 UNITYTLS_INVALID_HANDLE     ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT     = (unitytls_tlsctx_protocolrange)GetInt32(new IntPtr(p + 0x018)); // 0x18 UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT ( ModelEnumType unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange Int32 )
            value.Unitytls_errorstate_create                = GetObject<unitytls_errorstate_create_t>(new IntPtr(p + 0x020), ReversePrism.DataModels.unitytls_errorstate_create_t.FromPointer); // 0x20 Unitytls_errorstate_create  ( ModelClassType unitytls_errorstate_create_t unitytls_errorstate_create_t unitytls_errorstate_create_t Pointer )
            value.Unitytls_errorstate_raise_error           = GetObject<unitytls_errorstate_raise_error_t>(new IntPtr(p + 0x028), ReversePrism.DataModels.unitytls_errorstate_raise_error_t.FromPointer); // 0x28 Unitytls_errorstate_raise_error ( ModelClassType unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t Pointer )
            value.Unitytls_key_get_ref                      = GetObject<unitytls_key_get_ref_t>(new IntPtr(p + 0x030), ReversePrism.DataModels.unitytls_key_get_ref_t.FromPointer); // 0x30 Unitytls_key_get_ref        ( ModelClassType unitytls_key_get_ref_t unitytls_key_get_ref_t unitytls_key_get_ref_t Pointer )
            value.Unitytls_key_parse_der                    = GetObject<unitytls_key_parse_der_t>(new IntPtr(p + 0x038), ReversePrism.DataModels.unitytls_key_parse_der_t.FromPointer); // 0x38 Unitytls_key_parse_der      ( ModelClassType unitytls_key_parse_der_t unitytls_key_parse_der_t unitytls_key_parse_der_t Pointer )
            value.Unitytls_key_parse_pem                    = GetObject<unitytls_key_parse_pem_t>(new IntPtr(p + 0x040), ReversePrism.DataModels.unitytls_key_parse_pem_t.FromPointer); // 0x40 Unitytls_key_parse_pem      ( ModelClassType unitytls_key_parse_pem_t unitytls_key_parse_pem_t unitytls_key_parse_pem_t Pointer )
            value.Unitytls_key_free                         = GetObject<unitytls_key_free_t>(new IntPtr(p + 0x048), ReversePrism.DataModels.unitytls_key_free_t.FromPointer); // 0x48 Unitytls_key_free           ( ModelClassType unitytls_key_free_t unitytls_key_free_t unitytls_key_free_t Pointer )
            value.Unitytls_x509_export_der                  = GetObject<unitytls_x509_export_der_t>(new IntPtr(p + 0x050), ReversePrism.DataModels.unitytls_x509_export_der_t.FromPointer); // 0x50 Unitytls_x509_export_der    ( ModelClassType unitytls_x509_export_der_t unitytls_x509_export_der_t unitytls_x509_export_der_t Pointer )
            value.Unitytls_x509list_get_ref                 = GetObject<unitytls_x509list_get_ref_t>(new IntPtr(p + 0x058), ReversePrism.DataModels.unitytls_x509list_get_ref_t.FromPointer); // 0x58 Unitytls_x509list_get_ref   ( ModelClassType unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t Pointer )
            value.Unitytls_x509list_get_x509                = GetObject<unitytls_x509list_get_x509_t>(new IntPtr(p + 0x060), ReversePrism.DataModels.unitytls_x509list_get_x509_t.FromPointer); // 0x60 Unitytls_x509list_get_x509  ( ModelClassType unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t Pointer )
            value.Unitytls_x509list_create                  = GetObject<unitytls_x509list_create_t>(new IntPtr(p + 0x068), ReversePrism.DataModels.unitytls_x509list_create_t.FromPointer); // 0x68 Unitytls_x509list_create    ( ModelClassType unitytls_x509list_create_t unitytls_x509list_create_t unitytls_x509list_create_t Pointer )
            value.Unitytls_x509list_append                  = GetObject<unitytls_x509list_append_t>(new IntPtr(p + 0x070), ReversePrism.DataModels.unitytls_x509list_append_t.FromPointer); // 0x70 Unitytls_x509list_append    ( ModelClassType unitytls_x509list_append_t unitytls_x509list_append_t unitytls_x509list_append_t Pointer )
            value.Unitytls_x509list_append_der              = GetObject<unitytls_x509list_append_der_t>(new IntPtr(p + 0x078), ReversePrism.DataModels.unitytls_x509list_append_der_t.FromPointer); // 0x78 Unitytls_x509list_append_der ( ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer )
            value.Unitytls_x509list_append_pem              = GetObject<unitytls_x509list_append_der_t>(new IntPtr(p + 0x080), ReversePrism.DataModels.unitytls_x509list_append_der_t.FromPointer); // 0x80 Unitytls_x509list_append_pem ( ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer )
            value.Unitytls_x509list_free                    = GetObject<unitytls_x509list_free_t>(new IntPtr(p + 0x088), ReversePrism.DataModels.unitytls_x509list_free_t.FromPointer); // 0x88 Unitytls_x509list_free      ( ModelClassType unitytls_x509list_free_t unitytls_x509list_free_t unitytls_x509list_free_t Pointer )
            value.Unitytls_x509verify_default_ca            = GetObject<unitytls_x509verify_default_ca_t>(new IntPtr(p + 0x090), ReversePrism.DataModels.unitytls_x509verify_default_ca_t.FromPointer); // 0x90 Unitytls_x509verify_default_ca ( ModelClassType unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t Pointer )
            value.Unitytls_x509verify_explicit_ca           = GetObject<unitytls_x509verify_explicit_ca_t>(new IntPtr(p + 0x098), ReversePrism.DataModels.unitytls_x509verify_explicit_ca_t.FromPointer); // 0x98 Unitytls_x509verify_explicit_ca ( ModelClassType unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t Pointer )
            value.Unitytls_tlsctx_create_server             = GetObject<unitytls_tlsctx_create_server_t>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.unitytls_tlsctx_create_server_t.FromPointer); // 0xA0 Unitytls_tlsctx_create_server ( ModelClassType unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t Pointer )
            value.Unitytls_tlsctx_create_client             = GetObject<unitytls_tlsctx_create_client_t>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.unitytls_tlsctx_create_client_t.FromPointer); // 0xA8 Unitytls_tlsctx_create_client ( ModelClassType unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t Pointer )
            value.Unitytls_tlsctx_server_require_client_authentication = GetObject<unitytls_tlsctx_server_require_client_authentication_t>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.unitytls_tlsctx_server_require_client_authentication_t.FromPointer); // 0xB0 Unitytls_tlsctx_server_require_client_authentication ( ModelClassType unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t Pointer )
            value.Unitytls_tlsctx_set_certificate_callback  = GetObject<unitytls_tlsctx_set_certificate_callback_t>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.unitytls_tlsctx_set_certificate_callback_t.FromPointer); // 0xB8 Unitytls_tlsctx_set_certificate_callback ( ModelClassType unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t Pointer )
            value.Unitytls_tlsctx_set_trace_callback        = GetObject<unitytls_tlsctx_set_trace_callback_t>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.unitytls_tlsctx_set_trace_callback_t.FromPointer); // 0xC0 Unitytls_tlsctx_set_trace_callback ( ModelClassType unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t Pointer )
            value.Unitytls_tlsctx_set_x509verify_callback   = GetObject<unitytls_tlsctx_set_x509verify_callback_t>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.unitytls_tlsctx_set_x509verify_callback_t.FromPointer); // 0xC8 Unitytls_tlsctx_set_x509verify_callback ( ModelClassType unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t Pointer )
            value.Unitytls_tlsctx_set_supported_ciphersuites = GetObject<unitytls_tlsctx_set_supported_ciphersuites_t>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.unitytls_tlsctx_set_supported_ciphersuites_t.FromPointer); // 0xD0 Unitytls_tlsctx_set_supported_ciphersuites ( ModelClassType unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t Pointer )
            value.Unitytls_tlsctx_get_ciphersuite           = GetObject<unitytls_tlsctx_get_ciphersuite_t>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.unitytls_tlsctx_get_ciphersuite_t.FromPointer); // 0xD8 Unitytls_tlsctx_get_ciphersuite ( ModelClassType unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t Pointer )
            value.Unitytls_tlsctx_get_protocol              = GetObject<unitytls_tlsctx_get_protocol_t>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.unitytls_tlsctx_get_protocol_t.FromPointer); // 0xE0 Unitytls_tlsctx_get_protocol ( ModelClassType unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t Pointer )
            value.Unitytls_tlsctx_process_handshake         = GetObject<unitytls_tlsctx_process_handshake_t>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.unitytls_tlsctx_process_handshake_t.FromPointer); // 0xE8 Unitytls_tlsctx_process_handshake ( ModelClassType unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t Pointer )
            value.Unitytls_tlsctx_read                      = GetObject<unitytls_tlsctx_read_t>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.unitytls_tlsctx_read_t.FromPointer); // 0xF0 Unitytls_tlsctx_read        ( ModelClassType unitytls_tlsctx_read_t unitytls_tlsctx_read_t unitytls_tlsctx_read_t Pointer )
            value.Unitytls_tlsctx_write                     = GetObject<unitytls_tlsctx_write_t>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.unitytls_tlsctx_write_t.FromPointer); // 0xF8 Unitytls_tlsctx_write       ( ModelClassType unitytls_tlsctx_write_t unitytls_tlsctx_write_t unitytls_tlsctx_write_t Pointer )
            value.Unitytls_tlsctx_notify_close              = GetObject<unitytls_tlsctx_notify_close_t>(new IntPtr(p + 0x100), ReversePrism.DataModels.unitytls_tlsctx_notify_close_t.FromPointer); // 0x100 Unitytls_tlsctx_notify_close ( ModelClassType unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t Pointer )
            value.Unitytls_tlsctx_free                      = GetObject<unitytls_tlsctx_free_t>(new IntPtr(p + 0x108), ReversePrism.DataModels.unitytls_tlsctx_free_t.FromPointer); // 0x108 Unitytls_tlsctx_free        ( ModelClassType unitytls_tlsctx_free_t unitytls_tlsctx_free_t unitytls_tlsctx_free_t Pointer )
            value.Unitytls_random_generate_bytes            = GetObject<unitytls_random_generate_bytes_t>(new IntPtr(p + 0x110), ReversePrism.DataModels.unitytls_random_generate_bytes_t.FromPointer); // 0x110 Unitytls_random_generate_bytes ( ModelClassType unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t Pointer )

            return value;
        }
    }
}
