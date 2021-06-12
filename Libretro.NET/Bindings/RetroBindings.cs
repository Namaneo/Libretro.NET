using System;
using System.Runtime.InteropServices;

namespace Libretro.NET.Bindings
{
    public enum retro_language
    {
        RETRO_LANGUAGE_ENGLISH = 0,
        RETRO_LANGUAGE_JAPANESE = 1,
        RETRO_LANGUAGE_FRENCH = 2,
        RETRO_LANGUAGE_SPANISH = 3,
        RETRO_LANGUAGE_GERMAN = 4,
        RETRO_LANGUAGE_ITALIAN = 5,
        RETRO_LANGUAGE_DUTCH = 6,
        RETRO_LANGUAGE_PORTUGUESE_BRAZIL = 7,
        RETRO_LANGUAGE_PORTUGUESE_PORTUGAL = 8,
        RETRO_LANGUAGE_RUSSIAN = 9,
        RETRO_LANGUAGE_KOREAN = 10,
        RETRO_LANGUAGE_CHINESE_TRADITIONAL = 11,
        RETRO_LANGUAGE_CHINESE_SIMPLIFIED = 12,
        RETRO_LANGUAGE_ESPERANTO = 13,
        RETRO_LANGUAGE_POLISH = 14,
        RETRO_LANGUAGE_VIETNAMESE = 15,
        RETRO_LANGUAGE_ARABIC = 16,
        RETRO_LANGUAGE_GREEK = 17,
        RETRO_LANGUAGE_TURKISH = 18,
        RETRO_LANGUAGE_SLOVAK = 19,
        RETRO_LANGUAGE_PERSIAN = 20,
        RETRO_LANGUAGE_HEBREW = 21,
        RETRO_LANGUAGE_ASTURIAN = 22,
        RETRO_LANGUAGE_FINNISH = 23,
        RETRO_LANGUAGE_LAST,
        RETRO_LANGUAGE_DUMMY = 2147483647,
    }

    public enum retro_key
    {
        RETROK_UNKNOWN = 0,
        RETROK_FIRST = 0,
        RETROK_BACKSPACE = 8,
        RETROK_TAB = 9,
        RETROK_CLEAR = 12,
        RETROK_RETURN = 13,
        RETROK_PAUSE = 19,
        RETROK_ESCAPE = 27,
        RETROK_SPACE = 32,
        RETROK_EXCLAIM = 33,
        RETROK_QUOTEDBL = 34,
        RETROK_HASH = 35,
        RETROK_DOLLAR = 36,
        RETROK_AMPERSAND = 38,
        RETROK_QUOTE = 39,
        RETROK_LEFTPAREN = 40,
        RETROK_RIGHTPAREN = 41,
        RETROK_ASTERISK = 42,
        RETROK_PLUS = 43,
        RETROK_COMMA = 44,
        RETROK_MINUS = 45,
        RETROK_PERIOD = 46,
        RETROK_SLASH = 47,
        RETROK_0 = 48,
        RETROK_1 = 49,
        RETROK_2 = 50,
        RETROK_3 = 51,
        RETROK_4 = 52,
        RETROK_5 = 53,
        RETROK_6 = 54,
        RETROK_7 = 55,
        RETROK_8 = 56,
        RETROK_9 = 57,
        RETROK_COLON = 58,
        RETROK_SEMICOLON = 59,
        RETROK_LESS = 60,
        RETROK_EQUALS = 61,
        RETROK_GREATER = 62,
        RETROK_QUESTION = 63,
        RETROK_AT = 64,
        RETROK_LEFTBRACKET = 91,
        RETROK_BACKSLASH = 92,
        RETROK_RIGHTBRACKET = 93,
        RETROK_CARET = 94,
        RETROK_UNDERSCORE = 95,
        RETROK_BACKQUOTE = 96,
        RETROK_a = 97,
        RETROK_b = 98,
        RETROK_c = 99,
        RETROK_d = 100,
        RETROK_e = 101,
        RETROK_f = 102,
        RETROK_g = 103,
        RETROK_h = 104,
        RETROK_i = 105,
        RETROK_j = 106,
        RETROK_k = 107,
        RETROK_l = 108,
        RETROK_m = 109,
        RETROK_n = 110,
        RETROK_o = 111,
        RETROK_p = 112,
        RETROK_q = 113,
        RETROK_r = 114,
        RETROK_s = 115,
        RETROK_t = 116,
        RETROK_u = 117,
        RETROK_v = 118,
        RETROK_w = 119,
        RETROK_x = 120,
        RETROK_y = 121,
        RETROK_z = 122,
        RETROK_LEFTBRACE = 123,
        RETROK_BAR = 124,
        RETROK_RIGHTBRACE = 125,
        RETROK_TILDE = 126,
        RETROK_DELETE = 127,
        RETROK_KP0 = 256,
        RETROK_KP1 = 257,
        RETROK_KP2 = 258,
        RETROK_KP3 = 259,
        RETROK_KP4 = 260,
        RETROK_KP5 = 261,
        RETROK_KP6 = 262,
        RETROK_KP7 = 263,
        RETROK_KP8 = 264,
        RETROK_KP9 = 265,
        RETROK_KP_PERIOD = 266,
        RETROK_KP_DIVIDE = 267,
        RETROK_KP_MULTIPLY = 268,
        RETROK_KP_MINUS = 269,
        RETROK_KP_PLUS = 270,
        RETROK_KP_ENTER = 271,
        RETROK_KP_EQUALS = 272,
        RETROK_UP = 273,
        RETROK_DOWN = 274,
        RETROK_RIGHT = 275,
        RETROK_LEFT = 276,
        RETROK_INSERT = 277,
        RETROK_HOME = 278,
        RETROK_END = 279,
        RETROK_PAGEUP = 280,
        RETROK_PAGEDOWN = 281,
        RETROK_F1 = 282,
        RETROK_F2 = 283,
        RETROK_F3 = 284,
        RETROK_F4 = 285,
        RETROK_F5 = 286,
        RETROK_F6 = 287,
        RETROK_F7 = 288,
        RETROK_F8 = 289,
        RETROK_F9 = 290,
        RETROK_F10 = 291,
        RETROK_F11 = 292,
        RETROK_F12 = 293,
        RETROK_F13 = 294,
        RETROK_F14 = 295,
        RETROK_F15 = 296,
        RETROK_NUMLOCK = 300,
        RETROK_CAPSLOCK = 301,
        RETROK_SCROLLOCK = 302,
        RETROK_RSHIFT = 303,
        RETROK_LSHIFT = 304,
        RETROK_RCTRL = 305,
        RETROK_LCTRL = 306,
        RETROK_RALT = 307,
        RETROK_LALT = 308,
        RETROK_RMETA = 309,
        RETROK_LMETA = 310,
        RETROK_LSUPER = 311,
        RETROK_RSUPER = 312,
        RETROK_MODE = 313,
        RETROK_COMPOSE = 314,
        RETROK_HELP = 315,
        RETROK_PRINT = 316,
        RETROK_SYSREQ = 317,
        RETROK_BREAK = 318,
        RETROK_MENU = 319,
        RETROK_POWER = 320,
        RETROK_EURO = 321,
        RETROK_UNDO = 322,
        RETROK_OEM_102 = 323,
        RETROK_LAST,
        RETROK_DUMMY = 2147483647,
    }

    public enum retro_mod
    {
        RETROKMOD_NONE = 0x0000,
        RETROKMOD_SHIFT = 0x01,
        RETROKMOD_CTRL = 0x02,
        RETROKMOD_ALT = 0x04,
        RETROKMOD_META = 0x08,
        RETROKMOD_NUMLOCK = 0x10,
        RETROKMOD_CAPSLOCK = 0x20,
        RETROKMOD_SCROLLOCK = 0x40,
        RETROKMOD_DUMMY = 2147483647,
    }

    public partial struct retro_vfs_file_handle
    {
    }

    public partial struct retro_vfs_dir_handle
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("const char *")]
    public unsafe delegate sbyte* retro_vfs_get_path_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("struct retro_vfs_file_handle *")]
    public unsafe delegate retro_vfs_file_handle* retro_vfs_open_t([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("unsigned int")] uint mode, [NativeTypeName("unsigned int")] uint hints);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_close_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate long retro_vfs_size_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate long retro_vfs_truncate_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream, [NativeTypeName("int64_t")] long length);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate long retro_vfs_tell_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate long retro_vfs_seek_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream, [NativeTypeName("int64_t")] long offset, int seek_position);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate long retro_vfs_read_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream, [NativeTypeName("void *")] void* s, [NativeTypeName("uint64_t")] ulong len);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate long retro_vfs_write_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream, [NativeTypeName("const void *")] void* s, [NativeTypeName("uint64_t")] ulong len);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_flush_t([NativeTypeName("struct retro_vfs_file_handle *")] retro_vfs_file_handle* stream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_remove_t([NativeTypeName("const char *")] sbyte* path);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_rename_t([NativeTypeName("const char *")] sbyte* old_path, [NativeTypeName("const char *")] sbyte* new_path);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_stat_t([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("int32_t *")] int* size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_mkdir_t([NativeTypeName("const char *")] sbyte* dir);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("struct retro_vfs_dir_handle *")]
    public unsafe delegate retro_vfs_dir_handle* retro_vfs_opendir_t([NativeTypeName("const char *")] sbyte* dir, bool include_hidden);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_vfs_readdir_t([NativeTypeName("struct retro_vfs_dir_handle *")] retro_vfs_dir_handle* dirstream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("const char *")]
    public unsafe delegate sbyte* retro_vfs_dirent_get_name_t([NativeTypeName("struct retro_vfs_dir_handle *")] retro_vfs_dir_handle* dirstream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_vfs_dirent_is_dir_t([NativeTypeName("struct retro_vfs_dir_handle *")] retro_vfs_dir_handle* dirstream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int retro_vfs_closedir_t([NativeTypeName("struct retro_vfs_dir_handle *")] retro_vfs_dir_handle* dirstream);

    public partial struct retro_vfs_interface
    {
        [NativeTypeName("retro_vfs_get_path_t")]
        public IntPtr get_path;

        [NativeTypeName("retro_vfs_open_t")]
        public IntPtr open;

        [NativeTypeName("retro_vfs_close_t")]
        public IntPtr close;

        [NativeTypeName("retro_vfs_size_t")]
        public IntPtr size;

        [NativeTypeName("retro_vfs_tell_t")]
        public IntPtr tell;

        [NativeTypeName("retro_vfs_seek_t")]
        public IntPtr seek;

        [NativeTypeName("retro_vfs_read_t")]
        public IntPtr read;

        [NativeTypeName("retro_vfs_write_t")]
        public IntPtr write;

        [NativeTypeName("retro_vfs_flush_t")]
        public IntPtr flush;

        [NativeTypeName("retro_vfs_remove_t")]
        public IntPtr remove;

        [NativeTypeName("retro_vfs_rename_t")]
        public IntPtr rename;

        [NativeTypeName("retro_vfs_truncate_t")]
        public IntPtr truncate;

        [NativeTypeName("retro_vfs_stat_t")]
        public IntPtr stat;

        [NativeTypeName("retro_vfs_mkdir_t")]
        public IntPtr mkdir;

        [NativeTypeName("retro_vfs_opendir_t")]
        public IntPtr opendir;

        [NativeTypeName("retro_vfs_readdir_t")]
        public IntPtr readdir;

        [NativeTypeName("retro_vfs_dirent_get_name_t")]
        public IntPtr dirent_get_name;

        [NativeTypeName("retro_vfs_dirent_is_dir_t")]
        public IntPtr dirent_is_dir;

        [NativeTypeName("retro_vfs_closedir_t")]
        public IntPtr closedir;
    }

    public unsafe partial struct retro_vfs_interface_info
    {
        [NativeTypeName("uint32_t")]
        public uint required_interface_version;

        [NativeTypeName("struct retro_vfs_interface *")]
        public retro_vfs_interface* iface;
    }

    public enum retro_hw_render_interface_type
    {
        RETRO_HW_RENDER_INTERFACE_VULKAN = 0,
        RETRO_HW_RENDER_INTERFACE_D3D9 = 1,
        RETRO_HW_RENDER_INTERFACE_D3D10 = 2,
        RETRO_HW_RENDER_INTERFACE_D3D11 = 3,
        RETRO_HW_RENDER_INTERFACE_D3D12 = 4,
        RETRO_HW_RENDER_INTERFACE_GSKIT_PS2 = 5,
        RETRO_HW_RENDER_INTERFACE_DUMMY = 2147483647,
    }

    public partial struct retro_hw_render_interface
    {
        [NativeTypeName("enum retro_hw_render_interface_type")]
        public retro_hw_render_interface_type interface_type;

        [NativeTypeName("unsigned int")]
        public uint interface_version;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_set_led_state_t(int led, int state);

    public partial struct retro_led_interface
    {
        [NativeTypeName("retro_set_led_state_t")]
        public IntPtr set_led_state;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_midi_input_enabled_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_midi_output_enabled_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_midi_read_t([NativeTypeName("uint8_t *")] byte* @byte);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_midi_write_t([NativeTypeName("uint8_t")] byte @byte, [NativeTypeName("uint32_t")] uint delta_time);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_midi_flush_t();

    public partial struct retro_midi_interface
    {
        [NativeTypeName("retro_midi_input_enabled_t")]
        public IntPtr input_enabled;

        [NativeTypeName("retro_midi_output_enabled_t")]
        public IntPtr output_enabled;

        [NativeTypeName("retro_midi_read_t")]
        public IntPtr read;

        [NativeTypeName("retro_midi_write_t")]
        public IntPtr write;

        [NativeTypeName("retro_midi_flush_t")]
        public IntPtr flush;
    }

    public enum retro_hw_render_context_negotiation_interface_type
    {
        RETRO_HW_RENDER_CONTEXT_NEGOTIATION_INTERFACE_VULKAN = 0,
        RETRO_HW_RENDER_CONTEXT_NEGOTIATION_INTERFACE_DUMMY = 2147483647,
    }

    public partial struct retro_hw_render_context_negotiation_interface
    {
        [NativeTypeName("enum retro_hw_render_context_negotiation_interface_type")]
        public retro_hw_render_context_negotiation_interface_type interface_type;

        [NativeTypeName("unsigned int")]
        public uint interface_version;
    }

    public unsafe partial struct retro_memory_descriptor
    {
        [NativeTypeName("uint64_t")]
        public ulong flags;

        [NativeTypeName("void *")]
        public void* ptr;

        [NativeTypeName("size_t")]
        public UIntPtr offset;

        [NativeTypeName("size_t")]
        public UIntPtr start;

        [NativeTypeName("size_t")]
        public UIntPtr select;

        [NativeTypeName("size_t")]
        public UIntPtr disconnect;

        [NativeTypeName("size_t")]
        public UIntPtr len;

        [NativeTypeName("const char *")]
        public sbyte* addrspace;
    }

    public unsafe partial struct retro_memory_map
    {
        [NativeTypeName("const struct retro_memory_descriptor *")]
        public retro_memory_descriptor* descriptors;

        [NativeTypeName("unsigned int")]
        public uint num_descriptors;
    }

    public unsafe partial struct retro_controller_description
    {
        [NativeTypeName("const char *")]
        public sbyte* desc;

        [NativeTypeName("unsigned int")]
        public uint id;
    }

    public unsafe partial struct retro_controller_info
    {
        [NativeTypeName("const struct retro_controller_description *")]
        public retro_controller_description* types;

        [NativeTypeName("unsigned int")]
        public uint num_types;
    }

    public unsafe partial struct retro_subsystem_memory_info
    {
        [NativeTypeName("const char *")]
        public sbyte* extension;

        [NativeTypeName("unsigned int")]
        public uint type;
    }

    public unsafe partial struct retro_subsystem_rom_info
    {
        [NativeTypeName("const char *")]
        public sbyte* desc;

        [NativeTypeName("const char *")]
        public sbyte* valid_extensions;

        public bool need_fullpath;

        public bool block_extract;

        public bool required;

        [NativeTypeName("const struct retro_subsystem_memory_info *")]
        public retro_subsystem_memory_info* memory;

        [NativeTypeName("unsigned int")]
        public uint num_memory;
    }

    public unsafe partial struct retro_subsystem_info
    {
        [NativeTypeName("const char *")]
        public sbyte* desc;

        [NativeTypeName("const char *")]
        public sbyte* ident;

        [NativeTypeName("const struct retro_subsystem_rom_info *")]
        public retro_subsystem_rom_info* roms;

        [NativeTypeName("unsigned int")]
        public uint num_roms;

        [NativeTypeName("unsigned int")]
        public uint id;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_proc_address_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("retro_proc_address_t")]
    public unsafe delegate IntPtr retro_get_proc_address_t([NativeTypeName("const char *")] sbyte* sym);

    public partial struct retro_get_proc_address_interface
    {
        [NativeTypeName("retro_get_proc_address_t")]
        public IntPtr get_proc_address;
    }

    public enum retro_log_level
    {
        RETRO_LOG_DEBUG = 0,
        RETRO_LOG_INFO,
        RETRO_LOG_WARN,
        RETRO_LOG_ERROR,
        RETRO_LOG_DUMMY = 2147483647,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_log_printf_t([NativeTypeName("enum retro_log_level")] retro_log_level level, [NativeTypeName("const char *")] sbyte* fmt);

    public partial struct retro_log_callback
    {
        [NativeTypeName("retro_log_printf_t")]
        public IntPtr log;
    }

    public unsafe partial struct retro_perf_counter
    {
        [NativeTypeName("const char *")]
        public sbyte* ident;

        [NativeTypeName("retro_perf_tick_t")]
        public ulong start;

        [NativeTypeName("retro_perf_tick_t")]
        public ulong total;

        [NativeTypeName("retro_perf_tick_t")]
        public ulong call_cnt;

        public bool registered;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("retro_time_t")]
    public delegate long retro_perf_get_time_usec_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("retro_perf_tick_t")]
    public delegate ulong retro_perf_get_counter_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("uint64_t")]
    public delegate ulong retro_get_cpu_features_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_perf_log_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_perf_register_t([NativeTypeName("struct retro_perf_counter *")] retro_perf_counter* counter);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_perf_start_t([NativeTypeName("struct retro_perf_counter *")] retro_perf_counter* counter);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_perf_stop_t([NativeTypeName("struct retro_perf_counter *")] retro_perf_counter* counter);

    public partial struct retro_perf_callback
    {
        [NativeTypeName("retro_perf_get_time_usec_t")]
        public IntPtr get_time_usec;

        [NativeTypeName("retro_get_cpu_features_t")]
        public IntPtr get_cpu_features;

        [NativeTypeName("retro_perf_get_counter_t")]
        public IntPtr get_perf_counter;

        [NativeTypeName("retro_perf_register_t")]
        public IntPtr perf_register;

        [NativeTypeName("retro_perf_start_t")]
        public IntPtr perf_start;

        [NativeTypeName("retro_perf_stop_t")]
        public IntPtr perf_stop;

        [NativeTypeName("retro_perf_log_t")]
        public IntPtr perf_log;
    }

    public enum retro_sensor_action
    {
        RETRO_SENSOR_ACCELEROMETER_ENABLE = 0,
        RETRO_SENSOR_ACCELEROMETER_DISABLE,
        RETRO_SENSOR_GYROSCOPE_ENABLE,
        RETRO_SENSOR_GYROSCOPE_DISABLE,
        RETRO_SENSOR_ILLUMINANCE_ENABLE,
        RETRO_SENSOR_ILLUMINANCE_DISABLE,
        RETRO_SENSOR_DUMMY = 2147483647,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_set_sensor_state_t([NativeTypeName("unsigned int")] uint port, [NativeTypeName("enum retro_sensor_action")] retro_sensor_action action, [NativeTypeName("unsigned int")] uint rate);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float retro_sensor_get_input_t([NativeTypeName("unsigned int")] uint port, [NativeTypeName("unsigned int")] uint id);

    public partial struct retro_sensor_interface
    {
        [NativeTypeName("retro_set_sensor_state_t")]
        public IntPtr set_sensor_state;

        [NativeTypeName("retro_sensor_get_input_t")]
        public IntPtr get_sensor_input;
    }

    public enum retro_camera_buffer
    {
        RETRO_CAMERA_BUFFER_OPENGL_TEXTURE = 0,
        RETRO_CAMERA_BUFFER_RAW_FRAMEBUFFER,
        RETRO_CAMERA_BUFFER_DUMMY = 2147483647,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_camera_start_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_camera_stop_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_camera_lifetime_status_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_camera_frame_raw_framebuffer_t([NativeTypeName("const uint32_t *")] uint* buffer, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("size_t")] UIntPtr pitch);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_camera_frame_opengl_texture_t([NativeTypeName("unsigned int")] uint texture_id, [NativeTypeName("unsigned int")] uint texture_target, [NativeTypeName("const float *")] float* affine);

    public partial struct retro_camera_callback
    {
        [NativeTypeName("uint64_t")]
        public ulong caps;

        [NativeTypeName("unsigned int")]
        public uint width;

        [NativeTypeName("unsigned int")]
        public uint height;

        [NativeTypeName("retro_camera_start_t")]
        public IntPtr start;

        [NativeTypeName("retro_camera_stop_t")]
        public IntPtr stop;

        [NativeTypeName("retro_camera_frame_raw_framebuffer_t")]
        public IntPtr frame_raw_framebuffer;

        [NativeTypeName("retro_camera_frame_opengl_texture_t")]
        public IntPtr frame_opengl_texture;

        [NativeTypeName("retro_camera_lifetime_status_t")]
        public IntPtr initialized;

        [NativeTypeName("retro_camera_lifetime_status_t")]
        public IntPtr deinitialized;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_location_set_interval_t([NativeTypeName("unsigned int")] uint interval_ms, [NativeTypeName("unsigned int")] uint interval_distance);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_location_start_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_location_stop_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_location_get_position_t([NativeTypeName("double *")] double* lat, [NativeTypeName("double *")] double* lon, [NativeTypeName("double *")] double* horiz_accuracy, [NativeTypeName("double *")] double* vert_accuracy);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_location_lifetime_status_t();

    public partial struct retro_location_callback
    {
        [NativeTypeName("retro_location_start_t")]
        public IntPtr start;

        [NativeTypeName("retro_location_stop_t")]
        public IntPtr stop;

        [NativeTypeName("retro_location_get_position_t")]
        public IntPtr get_position;

        [NativeTypeName("retro_location_set_interval_t")]
        public IntPtr set_interval;

        [NativeTypeName("retro_location_lifetime_status_t")]
        public IntPtr initialized;

        [NativeTypeName("retro_location_lifetime_status_t")]
        public IntPtr deinitialized;
    }

    public enum retro_rumble_effect
    {
        RETRO_RUMBLE_STRONG = 0,
        RETRO_RUMBLE_WEAK = 1,
        RETRO_RUMBLE_DUMMY = 2147483647,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_set_rumble_state_t([NativeTypeName("unsigned int")] uint port, [NativeTypeName("enum retro_rumble_effect")] retro_rumble_effect effect, [NativeTypeName("uint16_t")] ushort strength);

    public partial struct retro_rumble_interface
    {
        [NativeTypeName("retro_set_rumble_state_t")]
        public IntPtr set_rumble_state;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_audio_callback_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_audio_set_state_callback_t(bool enabled);

    public partial struct retro_audio_callback
    {
        [NativeTypeName("retro_audio_callback_t")]
        public IntPtr callback;

        [NativeTypeName("retro_audio_set_state_callback_t")]
        public IntPtr set_state;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_frame_time_callback_t([NativeTypeName("retro_usec_t")] long usec);

    public partial struct retro_frame_time_callback
    {
        [NativeTypeName("retro_frame_time_callback_t")]
        public IntPtr callback;

        [NativeTypeName("retro_usec_t")]
        public long reference;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_audio_buffer_status_callback_t(bool active, [NativeTypeName("unsigned int")] uint occupancy, bool underrun_likely);

    public partial struct retro_audio_buffer_status_callback
    {
        [NativeTypeName("retro_audio_buffer_status_callback_t")]
        public IntPtr callback;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_hw_context_reset_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("uintptr_t")]
    public delegate UIntPtr retro_hw_get_current_framebuffer_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("retro_proc_address_t")]
    public unsafe delegate IntPtr retro_hw_get_proc_address_t([NativeTypeName("const char *")] sbyte* sym);

    public enum retro_hw_context_type
    {
        RETRO_HW_CONTEXT_NONE = 0,
        RETRO_HW_CONTEXT_OPENGL = 1,
        RETRO_HW_CONTEXT_OPENGLES2 = 2,
        RETRO_HW_CONTEXT_OPENGL_CORE = 3,
        RETRO_HW_CONTEXT_OPENGLES3 = 4,
        RETRO_HW_CONTEXT_OPENGLES_VERSION = 5,
        RETRO_HW_CONTEXT_VULKAN = 6,
        RETRO_HW_CONTEXT_DIRECT3D = 7,
        RETRO_HW_CONTEXT_DUMMY = 2147483647,
    }

    public partial struct retro_hw_render_callback
    {
        [NativeTypeName("enum retro_hw_context_type")]
        public retro_hw_context_type context_type;

        [NativeTypeName("retro_hw_context_reset_t")]
        public IntPtr context_reset;

        [NativeTypeName("retro_hw_get_current_framebuffer_t")]
        public IntPtr get_current_framebuffer;

        [NativeTypeName("retro_hw_get_proc_address_t")]
        public IntPtr get_proc_address;

        public bool depth;

        public bool stencil;

        public bool bottom_left_origin;

        [NativeTypeName("unsigned int")]
        public uint version_major;

        [NativeTypeName("unsigned int")]
        public uint version_minor;

        public bool cache_context;

        [NativeTypeName("retro_hw_context_reset_t")]
        public IntPtr context_destroy;

        public bool debug_context;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_keyboard_event_t(bool down, [NativeTypeName("unsigned int")] uint keycode, [NativeTypeName("uint32_t")] uint character, [NativeTypeName("uint16_t")] ushort key_modifiers);

    public partial struct retro_keyboard_callback
    {
        [NativeTypeName("retro_keyboard_event_t")]
        public IntPtr callback;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_set_eject_state_t(bool ejected);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_get_eject_state_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("unsigned int")]
    public delegate uint retro_get_image_index_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_set_image_index_t([NativeTypeName("unsigned int")] uint index);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("unsigned int")]
    public delegate uint retro_get_num_images_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_replace_image_index_t([NativeTypeName("unsigned int")] uint index, [NativeTypeName("const struct retro_game_info *")] retro_game_info* info);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool retro_add_image_index_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_set_initial_image_t([NativeTypeName("unsigned int")] uint index, [NativeTypeName("const char *")] sbyte* path);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_get_image_path_t([NativeTypeName("unsigned int")] uint index, [NativeTypeName("char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr len);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_get_image_label_t([NativeTypeName("unsigned int")] uint index, [NativeTypeName("char *")] sbyte* label, [NativeTypeName("size_t")] UIntPtr len);

    public partial struct retro_disk_control_callback
    {
        [NativeTypeName("retro_set_eject_state_t")]
        public IntPtr set_eject_state;

        [NativeTypeName("retro_get_eject_state_t")]
        public IntPtr get_eject_state;

        [NativeTypeName("retro_get_image_index_t")]
        public IntPtr get_image_index;

        [NativeTypeName("retro_set_image_index_t")]
        public IntPtr set_image_index;

        [NativeTypeName("retro_get_num_images_t")]
        public IntPtr get_num_images;

        [NativeTypeName("retro_replace_image_index_t")]
        public IntPtr replace_image_index;

        [NativeTypeName("retro_add_image_index_t")]
        public IntPtr add_image_index;
    }

    public partial struct retro_disk_control_ext_callback
    {
        [NativeTypeName("retro_set_eject_state_t")]
        public IntPtr set_eject_state;

        [NativeTypeName("retro_get_eject_state_t")]
        public IntPtr get_eject_state;

        [NativeTypeName("retro_get_image_index_t")]
        public IntPtr get_image_index;

        [NativeTypeName("retro_set_image_index_t")]
        public IntPtr set_image_index;

        [NativeTypeName("retro_get_num_images_t")]
        public IntPtr get_num_images;

        [NativeTypeName("retro_replace_image_index_t")]
        public IntPtr replace_image_index;

        [NativeTypeName("retro_add_image_index_t")]
        public IntPtr add_image_index;

        [NativeTypeName("retro_set_initial_image_t")]
        public IntPtr set_initial_image;

        [NativeTypeName("retro_get_image_path_t")]
        public IntPtr get_image_path;

        [NativeTypeName("retro_get_image_label_t")]
        public IntPtr get_image_label;
    }

    public enum retro_pixel_format
    {
        RETRO_PIXEL_FORMAT_0RGB1555 = 0,
        RETRO_PIXEL_FORMAT_XRGB8888 = 1,
        RETRO_PIXEL_FORMAT_RGB565 = 2,
        RETRO_PIXEL_FORMAT_UNKNOWN = 2147483647,
    }

    public unsafe partial struct retro_message
    {
        [NativeTypeName("const char *")]
        public sbyte* msg;

        [NativeTypeName("unsigned int")]
        public uint frames;
    }

    public enum retro_message_target
    {
        RETRO_MESSAGE_TARGET_ALL = 0,
        RETRO_MESSAGE_TARGET_OSD,
        RETRO_MESSAGE_TARGET_LOG,
    }

    public enum retro_message_type
    {
        RETRO_MESSAGE_TYPE_NOTIFICATION = 0,
        RETRO_MESSAGE_TYPE_NOTIFICATION_ALT,
        RETRO_MESSAGE_TYPE_STATUS,
        RETRO_MESSAGE_TYPE_PROGRESS,
    }

    public unsafe partial struct retro_message_ext
    {
        [NativeTypeName("const char *")]
        public sbyte* msg;

        [NativeTypeName("unsigned int")]
        public uint duration;

        [NativeTypeName("unsigned int")]
        public uint priority;

        [NativeTypeName("enum retro_log_level")]
        public retro_log_level level;

        [NativeTypeName("enum retro_message_target")]
        public retro_message_target target;

        [NativeTypeName("enum retro_message_type")]
        public retro_message_type type;

        [NativeTypeName("int8_t")]
        public sbyte progress;
    }

    public unsafe partial struct retro_input_descriptor
    {
        [NativeTypeName("unsigned int")]
        public uint port;

        [NativeTypeName("unsigned int")]
        public uint device;

        [NativeTypeName("unsigned int")]
        public uint index;

        [NativeTypeName("unsigned int")]
        public uint id;

        [NativeTypeName("const char *")]
        public sbyte* description;
    }

    public unsafe partial struct retro_system_info
    {
        [NativeTypeName("const char *")]
        public sbyte* library_name;

        [NativeTypeName("const char *")]
        public sbyte* library_version;

        [NativeTypeName("const char *")]
        public sbyte* valid_extensions;

        public bool need_fullpath;

        public bool block_extract;
    }

    public partial struct retro_game_geometry
    {
        [NativeTypeName("unsigned int")]
        public uint base_width;

        [NativeTypeName("unsigned int")]
        public uint base_height;

        [NativeTypeName("unsigned int")]
        public uint max_width;

        [NativeTypeName("unsigned int")]
        public uint max_height;

        public float aspect_ratio;
    }

    public partial struct retro_system_timing
    {
        public double fps;

        public double sample_rate;
    }

    public partial struct retro_system_av_info
    {
        [NativeTypeName("struct retro_game_geometry")]
        public retro_game_geometry geometry;

        [NativeTypeName("struct retro_system_timing")]
        public retro_system_timing timing;
    }

    public unsafe partial struct retro_variable
    {
        [NativeTypeName("const char *")]
        public sbyte* key;

        [NativeTypeName("const char *")]
        public sbyte* value;
    }

    public unsafe partial struct retro_core_option_display
    {
        [NativeTypeName("const char *")]
        public sbyte* key;

        public bool visible;
    }

    public unsafe partial struct retro_core_option_value
    {
        [NativeTypeName("const char *")]
        public sbyte* value;

        [NativeTypeName("const char *")]
        public sbyte* label;
    }

    public unsafe partial struct retro_core_option_definition
    {
        [NativeTypeName("const char *")]
        public sbyte* key;

        [NativeTypeName("const char *")]
        public sbyte* desc;

        [NativeTypeName("const char *")]
        public sbyte* info;

        [NativeTypeName("struct retro_core_option_value [128]")]
        public _values_e__FixedBuffer values;

        [NativeTypeName("const char *")]
        public sbyte* default_value;

        public partial struct _values_e__FixedBuffer
        {
            public retro_core_option_value e0;
            public retro_core_option_value e1;
            public retro_core_option_value e2;
            public retro_core_option_value e3;
            public retro_core_option_value e4;
            public retro_core_option_value e5;
            public retro_core_option_value e6;
            public retro_core_option_value e7;
            public retro_core_option_value e8;
            public retro_core_option_value e9;
            public retro_core_option_value e10;
            public retro_core_option_value e11;
            public retro_core_option_value e12;
            public retro_core_option_value e13;
            public retro_core_option_value e14;
            public retro_core_option_value e15;
            public retro_core_option_value e16;
            public retro_core_option_value e17;
            public retro_core_option_value e18;
            public retro_core_option_value e19;
            public retro_core_option_value e20;
            public retro_core_option_value e21;
            public retro_core_option_value e22;
            public retro_core_option_value e23;
            public retro_core_option_value e24;
            public retro_core_option_value e25;
            public retro_core_option_value e26;
            public retro_core_option_value e27;
            public retro_core_option_value e28;
            public retro_core_option_value e29;
            public retro_core_option_value e30;
            public retro_core_option_value e31;
            public retro_core_option_value e32;
            public retro_core_option_value e33;
            public retro_core_option_value e34;
            public retro_core_option_value e35;
            public retro_core_option_value e36;
            public retro_core_option_value e37;
            public retro_core_option_value e38;
            public retro_core_option_value e39;
            public retro_core_option_value e40;
            public retro_core_option_value e41;
            public retro_core_option_value e42;
            public retro_core_option_value e43;
            public retro_core_option_value e44;
            public retro_core_option_value e45;
            public retro_core_option_value e46;
            public retro_core_option_value e47;
            public retro_core_option_value e48;
            public retro_core_option_value e49;
            public retro_core_option_value e50;
            public retro_core_option_value e51;
            public retro_core_option_value e52;
            public retro_core_option_value e53;
            public retro_core_option_value e54;
            public retro_core_option_value e55;
            public retro_core_option_value e56;
            public retro_core_option_value e57;
            public retro_core_option_value e58;
            public retro_core_option_value e59;
            public retro_core_option_value e60;
            public retro_core_option_value e61;
            public retro_core_option_value e62;
            public retro_core_option_value e63;
            public retro_core_option_value e64;
            public retro_core_option_value e65;
            public retro_core_option_value e66;
            public retro_core_option_value e67;
            public retro_core_option_value e68;
            public retro_core_option_value e69;
            public retro_core_option_value e70;
            public retro_core_option_value e71;
            public retro_core_option_value e72;
            public retro_core_option_value e73;
            public retro_core_option_value e74;
            public retro_core_option_value e75;
            public retro_core_option_value e76;
            public retro_core_option_value e77;
            public retro_core_option_value e78;
            public retro_core_option_value e79;
            public retro_core_option_value e80;
            public retro_core_option_value e81;
            public retro_core_option_value e82;
            public retro_core_option_value e83;
            public retro_core_option_value e84;
            public retro_core_option_value e85;
            public retro_core_option_value e86;
            public retro_core_option_value e87;
            public retro_core_option_value e88;
            public retro_core_option_value e89;
            public retro_core_option_value e90;
            public retro_core_option_value e91;
            public retro_core_option_value e92;
            public retro_core_option_value e93;
            public retro_core_option_value e94;
            public retro_core_option_value e95;
            public retro_core_option_value e96;
            public retro_core_option_value e97;
            public retro_core_option_value e98;
            public retro_core_option_value e99;
            public retro_core_option_value e100;
            public retro_core_option_value e101;
            public retro_core_option_value e102;
            public retro_core_option_value e103;
            public retro_core_option_value e104;
            public retro_core_option_value e105;
            public retro_core_option_value e106;
            public retro_core_option_value e107;
            public retro_core_option_value e108;
            public retro_core_option_value e109;
            public retro_core_option_value e110;
            public retro_core_option_value e111;
            public retro_core_option_value e112;
            public retro_core_option_value e113;
            public retro_core_option_value e114;
            public retro_core_option_value e115;
            public retro_core_option_value e116;
            public retro_core_option_value e117;
            public retro_core_option_value e118;
            public retro_core_option_value e119;
            public retro_core_option_value e120;
            public retro_core_option_value e121;
            public retro_core_option_value e122;
            public retro_core_option_value e123;
            public retro_core_option_value e124;
            public retro_core_option_value e125;
            public retro_core_option_value e126;
            public retro_core_option_value e127;

            public unsafe ref retro_core_option_value this[int index]
            {
                get
                {
                    fixed (retro_core_option_value* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public unsafe partial struct retro_core_options_intl
    {
        [NativeTypeName("struct retro_core_option_definition *")]
        public retro_core_option_definition* us;

        [NativeTypeName("struct retro_core_option_definition *")]
        public retro_core_option_definition* local;
    }

    public unsafe partial struct retro_game_info
    {
        [NativeTypeName("const char *")]
        public sbyte* path;

        [NativeTypeName("const void *")]
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr size;

        [NativeTypeName("const char *")]
        public sbyte* meta;
    }

    public unsafe partial struct retro_framebuffer
    {
        [NativeTypeName("void *")]
        public void* data;

        [NativeTypeName("unsigned int")]
        public uint width;

        [NativeTypeName("unsigned int")]
        public uint height;

        [NativeTypeName("size_t")]
        public UIntPtr pitch;

        [NativeTypeName("enum retro_pixel_format")]
        public retro_pixel_format format;

        [NativeTypeName("unsigned int")]
        public uint access_flags;

        [NativeTypeName("unsigned int")]
        public uint memory_flags;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool retro_environment_t([NativeTypeName("unsigned int")] uint cmd, [NativeTypeName("void *")] void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void retro_video_refresh_t([NativeTypeName("const void *")] void* data, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, [NativeTypeName("size_t")] UIntPtr pitch);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_audio_sample_t([NativeTypeName("int16_t")] short left, [NativeTypeName("int16_t")] short right);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("size_t")]
    public unsafe delegate UIntPtr retro_audio_sample_batch_t([NativeTypeName("const int16_t *")] short* data, [NativeTypeName("size_t")] UIntPtr frames);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_input_poll_t();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int16_t")]
    public delegate short retro_input_state_t([NativeTypeName("unsigned int")] uint port, [NativeTypeName("unsigned int")] uint device, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("unsigned int")] uint id);

    public static unsafe partial class RetroBindings
    {
        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_environment", ExactSpelling = true)]
        public static extern void set_environment([NativeTypeName("retro_environment_t")] IntPtr param0);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_video_refresh", ExactSpelling = true)]
        public static extern void set_video_refresh([NativeTypeName("retro_video_refresh_t")] IntPtr param0);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_audio_sample", ExactSpelling = true)]
        public static extern void set_audio_sample([NativeTypeName("retro_audio_sample_t")] IntPtr param0);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_audio_sample_batch", ExactSpelling = true)]
        public static extern void set_audio_sample_batch([NativeTypeName("retro_audio_sample_batch_t")] IntPtr param0);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_input_poll", ExactSpelling = true)]
        public static extern void set_input_poll([NativeTypeName("retro_input_poll_t")] IntPtr param0);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_input_state", ExactSpelling = true)]
        public static extern void set_input_state([NativeTypeName("retro_input_state_t")] IntPtr param0);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_init", ExactSpelling = true)]
        public static extern void init();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_deinit", ExactSpelling = true)]
        public static extern void deinit();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_api_version", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint api_version();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_get_system_info", ExactSpelling = true)]
        public static extern void get_system_info([NativeTypeName("struct retro_system_info *")] retro_system_info* info);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_get_system_av_info", ExactSpelling = true)]
        public static extern void get_system_av_info([NativeTypeName("struct retro_system_av_info *")] retro_system_av_info* info);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_set_controller_port_device", ExactSpelling = true)]
        public static extern void set_controller_port_device([NativeTypeName("unsigned int")] uint port, [NativeTypeName("unsigned int")] uint device);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_reset", ExactSpelling = true)]
        public static extern void reset();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_run", ExactSpelling = true)]
        public static extern void run();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_serialize_size", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr serialize_size();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_serialize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte serialize([NativeTypeName("void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_unserialize", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte unserialize([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr size);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_cheat_reset", ExactSpelling = true)]
        public static extern void cheat_reset();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_cheat_set", ExactSpelling = true)]
        public static extern void cheat_set([NativeTypeName("unsigned int")] uint index, [NativeTypeName("bool")] byte enabled, [NativeTypeName("const char *")] sbyte* code);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_load_game", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte load_game([NativeTypeName("const struct retro_game_info *")] retro_game_info* game);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_load_game_special", ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte load_game_special([NativeTypeName("unsigned int")] uint game_type, [NativeTypeName("const struct retro_game_info *")] retro_game_info* info, [NativeTypeName("size_t")] UIntPtr num_info);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_unload_game", ExactSpelling = true)]
        public static extern void unload_game();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_get_region", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint get_region();

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_get_memory_data", ExactSpelling = true)]
        [return: NativeTypeName("void *")]
        public static extern void* get_memory_data([NativeTypeName("unsigned int")] uint id);

        [DllImport("core", CallingConvention = CallingConvention.Cdecl, EntryPoint = "retro_get_memory_size", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr get_memory_size([NativeTypeName("unsigned int")] uint id);

        [NativeTypeName("#define RETRO_API_VERSION 1")]
        public const int RETRO_API_VERSION = 1;

        [NativeTypeName("#define RETRO_DEVICE_TYPE_SHIFT 8")]
        public const int RETRO_DEVICE_TYPE_SHIFT = 8;

        [NativeTypeName("#define RETRO_DEVICE_MASK ((1 << RETRO_DEVICE_TYPE_SHIFT) - 1)")]
        public const int RETRO_DEVICE_MASK = ((1 << 8) - 1);

        [NativeTypeName("#define RETRO_DEVICE_NONE 0")]
        public const int RETRO_DEVICE_NONE = 0;

        [NativeTypeName("#define RETRO_DEVICE_JOYPAD 1")]
        public const int RETRO_DEVICE_JOYPAD = 1;

        [NativeTypeName("#define RETRO_DEVICE_MOUSE 2")]
        public const int RETRO_DEVICE_MOUSE = 2;

        [NativeTypeName("#define RETRO_DEVICE_KEYBOARD 3")]
        public const int RETRO_DEVICE_KEYBOARD = 3;

        [NativeTypeName("#define RETRO_DEVICE_LIGHTGUN 4")]
        public const int RETRO_DEVICE_LIGHTGUN = 4;

        [NativeTypeName("#define RETRO_DEVICE_ANALOG 5")]
        public const int RETRO_DEVICE_ANALOG = 5;

        [NativeTypeName("#define RETRO_DEVICE_POINTER 6")]
        public const int RETRO_DEVICE_POINTER = 6;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_B 0")]
        public const int RETRO_DEVICE_ID_JOYPAD_B = 0;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_Y 1")]
        public const int RETRO_DEVICE_ID_JOYPAD_Y = 1;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_SELECT 2")]
        public const int RETRO_DEVICE_ID_JOYPAD_SELECT = 2;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_START 3")]
        public const int RETRO_DEVICE_ID_JOYPAD_START = 3;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_UP 4")]
        public const int RETRO_DEVICE_ID_JOYPAD_UP = 4;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_DOWN 5")]
        public const int RETRO_DEVICE_ID_JOYPAD_DOWN = 5;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_LEFT 6")]
        public const int RETRO_DEVICE_ID_JOYPAD_LEFT = 6;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_RIGHT 7")]
        public const int RETRO_DEVICE_ID_JOYPAD_RIGHT = 7;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_A 8")]
        public const int RETRO_DEVICE_ID_JOYPAD_A = 8;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_X 9")]
        public const int RETRO_DEVICE_ID_JOYPAD_X = 9;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_L 10")]
        public const int RETRO_DEVICE_ID_JOYPAD_L = 10;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_R 11")]
        public const int RETRO_DEVICE_ID_JOYPAD_R = 11;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_L2 12")]
        public const int RETRO_DEVICE_ID_JOYPAD_L2 = 12;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_R2 13")]
        public const int RETRO_DEVICE_ID_JOYPAD_R2 = 13;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_L3 14")]
        public const int RETRO_DEVICE_ID_JOYPAD_L3 = 14;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_R3 15")]
        public const int RETRO_DEVICE_ID_JOYPAD_R3 = 15;

        [NativeTypeName("#define RETRO_DEVICE_ID_JOYPAD_MASK 256")]
        public const int RETRO_DEVICE_ID_JOYPAD_MASK = 256;

        [NativeTypeName("#define RETRO_DEVICE_INDEX_ANALOG_LEFT 0")]
        public const int RETRO_DEVICE_INDEX_ANALOG_LEFT = 0;

        [NativeTypeName("#define RETRO_DEVICE_INDEX_ANALOG_RIGHT 1")]
        public const int RETRO_DEVICE_INDEX_ANALOG_RIGHT = 1;

        [NativeTypeName("#define RETRO_DEVICE_INDEX_ANALOG_BUTTON 2")]
        public const int RETRO_DEVICE_INDEX_ANALOG_BUTTON = 2;

        [NativeTypeName("#define RETRO_DEVICE_ID_ANALOG_X 0")]
        public const int RETRO_DEVICE_ID_ANALOG_X = 0;

        [NativeTypeName("#define RETRO_DEVICE_ID_ANALOG_Y 1")]
        public const int RETRO_DEVICE_ID_ANALOG_Y = 1;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_X 0")]
        public const int RETRO_DEVICE_ID_MOUSE_X = 0;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_Y 1")]
        public const int RETRO_DEVICE_ID_MOUSE_Y = 1;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_LEFT 2")]
        public const int RETRO_DEVICE_ID_MOUSE_LEFT = 2;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_RIGHT 3")]
        public const int RETRO_DEVICE_ID_MOUSE_RIGHT = 3;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_WHEELUP 4")]
        public const int RETRO_DEVICE_ID_MOUSE_WHEELUP = 4;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_WHEELDOWN 5")]
        public const int RETRO_DEVICE_ID_MOUSE_WHEELDOWN = 5;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_MIDDLE 6")]
        public const int RETRO_DEVICE_ID_MOUSE_MIDDLE = 6;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_HORIZ_WHEELUP 7")]
        public const int RETRO_DEVICE_ID_MOUSE_HORIZ_WHEELUP = 7;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_HORIZ_WHEELDOWN 8")]
        public const int RETRO_DEVICE_ID_MOUSE_HORIZ_WHEELDOWN = 8;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_BUTTON_4 9")]
        public const int RETRO_DEVICE_ID_MOUSE_BUTTON_4 = 9;

        [NativeTypeName("#define RETRO_DEVICE_ID_MOUSE_BUTTON_5 10")]
        public const int RETRO_DEVICE_ID_MOUSE_BUTTON_5 = 10;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_SCREEN_X 13")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_SCREEN_X = 13;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_SCREEN_Y 14")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_SCREEN_Y = 14;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_IS_OFFSCREEN 15")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_IS_OFFSCREEN = 15;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_TRIGGER 2")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_TRIGGER = 2;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_RELOAD 16")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_RELOAD = 16;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_AUX_A 3")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_AUX_A = 3;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_AUX_B 4")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_AUX_B = 4;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_START 6")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_START = 6;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_SELECT 7")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_SELECT = 7;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_AUX_C 8")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_AUX_C = 8;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_DPAD_UP 9")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_DPAD_UP = 9;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_DPAD_DOWN 10")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_DPAD_DOWN = 10;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_DPAD_LEFT 11")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_DPAD_LEFT = 11;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_DPAD_RIGHT 12")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_DPAD_RIGHT = 12;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_X 0")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_X = 0;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_Y 1")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_Y = 1;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_CURSOR 3")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_CURSOR = 3;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_TURBO 4")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_TURBO = 4;

        [NativeTypeName("#define RETRO_DEVICE_ID_LIGHTGUN_PAUSE 5")]
        public const int RETRO_DEVICE_ID_LIGHTGUN_PAUSE = 5;

        [NativeTypeName("#define RETRO_DEVICE_ID_POINTER_X 0")]
        public const int RETRO_DEVICE_ID_POINTER_X = 0;

        [NativeTypeName("#define RETRO_DEVICE_ID_POINTER_Y 1")]
        public const int RETRO_DEVICE_ID_POINTER_Y = 1;

        [NativeTypeName("#define RETRO_DEVICE_ID_POINTER_PRESSED 2")]
        public const int RETRO_DEVICE_ID_POINTER_PRESSED = 2;

        [NativeTypeName("#define RETRO_DEVICE_ID_POINTER_COUNT 3")]
        public const int RETRO_DEVICE_ID_POINTER_COUNT = 3;

        [NativeTypeName("#define RETRO_REGION_NTSC 0")]
        public const int RETRO_REGION_NTSC = 0;

        [NativeTypeName("#define RETRO_REGION_PAL 1")]
        public const int RETRO_REGION_PAL = 1;

        [NativeTypeName("#define RETRO_MEMORY_MASK 0xff")]
        public const int RETRO_MEMORY_MASK = 0xff;

        [NativeTypeName("#define RETRO_MEMORY_SAVE_RAM 0")]
        public const int RETRO_MEMORY_SAVE_RAM = 0;

        [NativeTypeName("#define RETRO_MEMORY_RTC 1")]
        public const int RETRO_MEMORY_RTC = 1;

        [NativeTypeName("#define RETRO_MEMORY_SYSTEM_RAM 2")]
        public const int RETRO_MEMORY_SYSTEM_RAM = 2;

        [NativeTypeName("#define RETRO_MEMORY_VIDEO_RAM 3")]
        public const int RETRO_MEMORY_VIDEO_RAM = 3;

        [NativeTypeName("#define RETRO_ENVIRONMENT_EXPERIMENTAL 0x10000")]
        public const int RETRO_ENVIRONMENT_EXPERIMENTAL = 0x10000;

        [NativeTypeName("#define RETRO_ENVIRONMENT_PRIVATE 0x20000")]
        public const int RETRO_ENVIRONMENT_PRIVATE = 0x20000;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_ROTATION 1")]
        public const int RETRO_ENVIRONMENT_SET_ROTATION = 1;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_OVERSCAN 2")]
        public const int RETRO_ENVIRONMENT_GET_OVERSCAN = 2;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_CAN_DUPE 3")]
        public const int RETRO_ENVIRONMENT_GET_CAN_DUPE = 3;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_MESSAGE 6")]
        public const int RETRO_ENVIRONMENT_SET_MESSAGE = 6;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SHUTDOWN 7")]
        public const int RETRO_ENVIRONMENT_SHUTDOWN = 7;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_PERFORMANCE_LEVEL 8")]
        public const int RETRO_ENVIRONMENT_SET_PERFORMANCE_LEVEL = 8;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_SYSTEM_DIRECTORY 9")]
        public const int RETRO_ENVIRONMENT_GET_SYSTEM_DIRECTORY = 9;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_PIXEL_FORMAT 10")]
        public const int RETRO_ENVIRONMENT_SET_PIXEL_FORMAT = 10;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_INPUT_DESCRIPTORS 11")]
        public const int RETRO_ENVIRONMENT_SET_INPUT_DESCRIPTORS = 11;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_KEYBOARD_CALLBACK 12")]
        public const int RETRO_ENVIRONMENT_SET_KEYBOARD_CALLBACK = 12;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_DISK_CONTROL_INTERFACE 13")]
        public const int RETRO_ENVIRONMENT_SET_DISK_CONTROL_INTERFACE = 13;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_HW_RENDER 14")]
        public const int RETRO_ENVIRONMENT_SET_HW_RENDER = 14;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_VARIABLE 15")]
        public const int RETRO_ENVIRONMENT_GET_VARIABLE = 15;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_VARIABLES 16")]
        public const int RETRO_ENVIRONMENT_SET_VARIABLES = 16;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_VARIABLE_UPDATE 17")]
        public const int RETRO_ENVIRONMENT_GET_VARIABLE_UPDATE = 17;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_SUPPORT_NO_GAME 18")]
        public const int RETRO_ENVIRONMENT_SET_SUPPORT_NO_GAME = 18;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_LIBRETRO_PATH 19")]
        public const int RETRO_ENVIRONMENT_GET_LIBRETRO_PATH = 19;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_FRAME_TIME_CALLBACK 21")]
        public const int RETRO_ENVIRONMENT_SET_FRAME_TIME_CALLBACK = 21;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_AUDIO_CALLBACK 22")]
        public const int RETRO_ENVIRONMENT_SET_AUDIO_CALLBACK = 22;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_RUMBLE_INTERFACE 23")]
        public const int RETRO_ENVIRONMENT_GET_RUMBLE_INTERFACE = 23;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_INPUT_DEVICE_CAPABILITIES 24")]
        public const int RETRO_ENVIRONMENT_GET_INPUT_DEVICE_CAPABILITIES = 24;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_SENSOR_INTERFACE (25 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_SENSOR_INTERFACE = (25 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_CAMERA_INTERFACE (26 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_CAMERA_INTERFACE = (26 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_LOG_INTERFACE 27")]
        public const int RETRO_ENVIRONMENT_GET_LOG_INTERFACE = 27;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_PERF_INTERFACE 28")]
        public const int RETRO_ENVIRONMENT_GET_PERF_INTERFACE = 28;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_LOCATION_INTERFACE 29")]
        public const int RETRO_ENVIRONMENT_GET_LOCATION_INTERFACE = 29;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_CONTENT_DIRECTORY 30")]
        public const int RETRO_ENVIRONMENT_GET_CONTENT_DIRECTORY = 30;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_CORE_ASSETS_DIRECTORY 30")]
        public const int RETRO_ENVIRONMENT_GET_CORE_ASSETS_DIRECTORY = 30;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_SAVE_DIRECTORY 31")]
        public const int RETRO_ENVIRONMENT_GET_SAVE_DIRECTORY = 31;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_SYSTEM_AV_INFO 32")]
        public const int RETRO_ENVIRONMENT_SET_SYSTEM_AV_INFO = 32;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_PROC_ADDRESS_CALLBACK 33")]
        public const int RETRO_ENVIRONMENT_SET_PROC_ADDRESS_CALLBACK = 33;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_SUBSYSTEM_INFO 34")]
        public const int RETRO_ENVIRONMENT_SET_SUBSYSTEM_INFO = 34;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_CONTROLLER_INFO 35")]
        public const int RETRO_ENVIRONMENT_SET_CONTROLLER_INFO = 35;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_MEMORY_MAPS (36 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_SET_MEMORY_MAPS = (36 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_GEOMETRY 37")]
        public const int RETRO_ENVIRONMENT_SET_GEOMETRY = 37;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_USERNAME 38")]
        public const int RETRO_ENVIRONMENT_GET_USERNAME = 38;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_LANGUAGE 39")]
        public const int RETRO_ENVIRONMENT_GET_LANGUAGE = 39;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_CURRENT_SOFTWARE_FRAMEBUFFER (40 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_CURRENT_SOFTWARE_FRAMEBUFFER = (40 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_HW_RENDER_INTERFACE (41 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_HW_RENDER_INTERFACE = (41 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_SUPPORT_ACHIEVEMENTS (42 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_SET_SUPPORT_ACHIEVEMENTS = (42 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_HW_RENDER_CONTEXT_NEGOTIATION_INTERFACE (43 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_SET_HW_RENDER_CONTEXT_NEGOTIATION_INTERFACE = (43 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_SERIALIZATION_QUIRKS 44")]
        public const int RETRO_ENVIRONMENT_SET_SERIALIZATION_QUIRKS = 44;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_HW_SHARED_CONTEXT (44 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_SET_HW_SHARED_CONTEXT = (44 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_VFS_INTERFACE (45 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_VFS_INTERFACE = (45 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_LED_INTERFACE (46 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_LED_INTERFACE = (46 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_AUDIO_VIDEO_ENABLE (47 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_AUDIO_VIDEO_ENABLE = (47 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_MIDI_INTERFACE (48 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_MIDI_INTERFACE = (48 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_FASTFORWARDING (49 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_FASTFORWARDING = (49 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_TARGET_REFRESH_RATE (50 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_TARGET_REFRESH_RATE = (50 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_INPUT_BITMASKS (51 | RETRO_ENVIRONMENT_EXPERIMENTAL)")]
        public const int RETRO_ENVIRONMENT_GET_INPUT_BITMASKS = (51 | 0x10000);

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_CORE_OPTIONS_VERSION 52")]
        public const int RETRO_ENVIRONMENT_GET_CORE_OPTIONS_VERSION = 52;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_CORE_OPTIONS 53")]
        public const int RETRO_ENVIRONMENT_SET_CORE_OPTIONS = 53;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_CORE_OPTIONS_INTL 54")]
        public const int RETRO_ENVIRONMENT_SET_CORE_OPTIONS_INTL = 54;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_CORE_OPTIONS_DISPLAY 55")]
        public const int RETRO_ENVIRONMENT_SET_CORE_OPTIONS_DISPLAY = 55;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_PREFERRED_HW_RENDER 56")]
        public const int RETRO_ENVIRONMENT_GET_PREFERRED_HW_RENDER = 56;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_DISK_CONTROL_INTERFACE_VERSION 57")]
        public const int RETRO_ENVIRONMENT_GET_DISK_CONTROL_INTERFACE_VERSION = 57;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_DISK_CONTROL_EXT_INTERFACE 58")]
        public const int RETRO_ENVIRONMENT_SET_DISK_CONTROL_EXT_INTERFACE = 58;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_MESSAGE_INTERFACE_VERSION 59")]
        public const int RETRO_ENVIRONMENT_GET_MESSAGE_INTERFACE_VERSION = 59;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_MESSAGE_EXT 60")]
        public const int RETRO_ENVIRONMENT_SET_MESSAGE_EXT = 60;

        [NativeTypeName("#define RETRO_ENVIRONMENT_GET_INPUT_MAX_USERS 61")]
        public const int RETRO_ENVIRONMENT_GET_INPUT_MAX_USERS = 61;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_AUDIO_BUFFER_STATUS_CALLBACK 62")]
        public const int RETRO_ENVIRONMENT_SET_AUDIO_BUFFER_STATUS_CALLBACK = 62;

        [NativeTypeName("#define RETRO_ENVIRONMENT_SET_MINIMUM_AUDIO_LATENCY 63")]
        public const int RETRO_ENVIRONMENT_SET_MINIMUM_AUDIO_LATENCY = 63;

        [NativeTypeName("#define RETRO_VFS_FILE_ACCESS_READ (1 << 0)")]
        public const int RETRO_VFS_FILE_ACCESS_READ = (1 << 0);

        [NativeTypeName("#define RETRO_VFS_FILE_ACCESS_WRITE (1 << 1)")]
        public const int RETRO_VFS_FILE_ACCESS_WRITE = (1 << 1);

        [NativeTypeName("#define RETRO_VFS_FILE_ACCESS_READ_WRITE (RETRO_VFS_FILE_ACCESS_READ | RETRO_VFS_FILE_ACCESS_WRITE)")]
        public const int RETRO_VFS_FILE_ACCESS_READ_WRITE = ((1 << 0) | (1 << 1));

        [NativeTypeName("#define RETRO_VFS_FILE_ACCESS_UPDATE_EXISTING (1 << 2)")]
        public const int RETRO_VFS_FILE_ACCESS_UPDATE_EXISTING = (1 << 2);

        [NativeTypeName("#define RETRO_VFS_FILE_ACCESS_HINT_NONE (0)")]
        public const int RETRO_VFS_FILE_ACCESS_HINT_NONE = (0);

        [NativeTypeName("#define RETRO_VFS_FILE_ACCESS_HINT_FREQUENT_ACCESS (1 << 0)")]
        public const int RETRO_VFS_FILE_ACCESS_HINT_FREQUENT_ACCESS = (1 << 0);

        [NativeTypeName("#define RETRO_VFS_SEEK_POSITION_START 0")]
        public const int RETRO_VFS_SEEK_POSITION_START = 0;

        [NativeTypeName("#define RETRO_VFS_SEEK_POSITION_CURRENT 1")]
        public const int RETRO_VFS_SEEK_POSITION_CURRENT = 1;

        [NativeTypeName("#define RETRO_VFS_SEEK_POSITION_END 2")]
        public const int RETRO_VFS_SEEK_POSITION_END = 2;

        [NativeTypeName("#define RETRO_VFS_STAT_IS_VALID (1 << 0)")]
        public const int RETRO_VFS_STAT_IS_VALID = (1 << 0);

        [NativeTypeName("#define RETRO_VFS_STAT_IS_DIRECTORY (1 << 1)")]
        public const int RETRO_VFS_STAT_IS_DIRECTORY = (1 << 1);

        [NativeTypeName("#define RETRO_VFS_STAT_IS_CHARACTER_SPECIAL (1 << 2)")]
        public const int RETRO_VFS_STAT_IS_CHARACTER_SPECIAL = (1 << 2);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_INCOMPLETE (1 << 0)")]
        public const int RETRO_SERIALIZATION_QUIRK_INCOMPLETE = (1 << 0);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_MUST_INITIALIZE (1 << 1)")]
        public const int RETRO_SERIALIZATION_QUIRK_MUST_INITIALIZE = (1 << 1);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_CORE_VARIABLE_SIZE (1 << 2)")]
        public const int RETRO_SERIALIZATION_QUIRK_CORE_VARIABLE_SIZE = (1 << 2);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_FRONT_VARIABLE_SIZE (1 << 3)")]
        public const int RETRO_SERIALIZATION_QUIRK_FRONT_VARIABLE_SIZE = (1 << 3);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_SINGLE_SESSION (1 << 4)")]
        public const int RETRO_SERIALIZATION_QUIRK_SINGLE_SESSION = (1 << 4);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_ENDIAN_DEPENDENT (1 << 5)")]
        public const int RETRO_SERIALIZATION_QUIRK_ENDIAN_DEPENDENT = (1 << 5);

        [NativeTypeName("#define RETRO_SERIALIZATION_QUIRK_PLATFORM_DEPENDENT (1 << 6)")]
        public const int RETRO_SERIALIZATION_QUIRK_PLATFORM_DEPENDENT = (1 << 6);

        [NativeTypeName("#define RETRO_MEMDESC_CONST (1 << 0)")]
        public const int RETRO_MEMDESC_CONST = (1 << 0);

        [NativeTypeName("#define RETRO_MEMDESC_BIGENDIAN (1 << 1)")]
        public const int RETRO_MEMDESC_BIGENDIAN = (1 << 1);

        [NativeTypeName("#define RETRO_MEMDESC_SYSTEM_RAM (1 << 2)")]
        public const int RETRO_MEMDESC_SYSTEM_RAM = (1 << 2);

        [NativeTypeName("#define RETRO_MEMDESC_SAVE_RAM (1 << 3)")]
        public const int RETRO_MEMDESC_SAVE_RAM = (1 << 3);

        [NativeTypeName("#define RETRO_MEMDESC_VIDEO_RAM (1 << 4)")]
        public const int RETRO_MEMDESC_VIDEO_RAM = (1 << 4);

        [NativeTypeName("#define RETRO_MEMDESC_ALIGN_2 (1 << 16)")]
        public const int RETRO_MEMDESC_ALIGN_2 = (1 << 16);

        [NativeTypeName("#define RETRO_MEMDESC_ALIGN_4 (2 << 16)")]
        public const int RETRO_MEMDESC_ALIGN_4 = (2 << 16);

        [NativeTypeName("#define RETRO_MEMDESC_ALIGN_8 (3 << 16)")]
        public const int RETRO_MEMDESC_ALIGN_8 = (3 << 16);

        [NativeTypeName("#define RETRO_MEMDESC_MINSIZE_2 (1 << 24)")]
        public const int RETRO_MEMDESC_MINSIZE_2 = (1 << 24);

        [NativeTypeName("#define RETRO_MEMDESC_MINSIZE_4 (2 << 24)")]
        public const int RETRO_MEMDESC_MINSIZE_4 = (2 << 24);

        [NativeTypeName("#define RETRO_MEMDESC_MINSIZE_8 (3 << 24)")]
        public const int RETRO_MEMDESC_MINSIZE_8 = (3 << 24);

        [NativeTypeName("#define RETRO_SIMD_SSE (1 << 0)")]
        public const int RETRO_SIMD_SSE = (1 << 0);

        [NativeTypeName("#define RETRO_SIMD_SSE2 (1 << 1)")]
        public const int RETRO_SIMD_SSE2 = (1 << 1);

        [NativeTypeName("#define RETRO_SIMD_VMX (1 << 2)")]
        public const int RETRO_SIMD_VMX = (1 << 2);

        [NativeTypeName("#define RETRO_SIMD_VMX128 (1 << 3)")]
        public const int RETRO_SIMD_VMX128 = (1 << 3);

        [NativeTypeName("#define RETRO_SIMD_AVX (1 << 4)")]
        public const int RETRO_SIMD_AVX = (1 << 4);

        [NativeTypeName("#define RETRO_SIMD_NEON (1 << 5)")]
        public const int RETRO_SIMD_NEON = (1 << 5);

        [NativeTypeName("#define RETRO_SIMD_SSE3 (1 << 6)")]
        public const int RETRO_SIMD_SSE3 = (1 << 6);

        [NativeTypeName("#define RETRO_SIMD_SSSE3 (1 << 7)")]
        public const int RETRO_SIMD_SSSE3 = (1 << 7);

        [NativeTypeName("#define RETRO_SIMD_MMX (1 << 8)")]
        public const int RETRO_SIMD_MMX = (1 << 8);

        [NativeTypeName("#define RETRO_SIMD_MMXEXT (1 << 9)")]
        public const int RETRO_SIMD_MMXEXT = (1 << 9);

        [NativeTypeName("#define RETRO_SIMD_SSE4 (1 << 10)")]
        public const int RETRO_SIMD_SSE4 = (1 << 10);

        [NativeTypeName("#define RETRO_SIMD_SSE42 (1 << 11)")]
        public const int RETRO_SIMD_SSE42 = (1 << 11);

        [NativeTypeName("#define RETRO_SIMD_AVX2 (1 << 12)")]
        public const int RETRO_SIMD_AVX2 = (1 << 12);

        [NativeTypeName("#define RETRO_SIMD_VFPU (1 << 13)")]
        public const int RETRO_SIMD_VFPU = (1 << 13);

        [NativeTypeName("#define RETRO_SIMD_PS (1 << 14)")]
        public const int RETRO_SIMD_PS = (1 << 14);

        [NativeTypeName("#define RETRO_SIMD_AES (1 << 15)")]
        public const int RETRO_SIMD_AES = (1 << 15);

        [NativeTypeName("#define RETRO_SIMD_VFPV3 (1 << 16)")]
        public const int RETRO_SIMD_VFPV3 = (1 << 16);

        [NativeTypeName("#define RETRO_SIMD_VFPV4 (1 << 17)")]
        public const int RETRO_SIMD_VFPV4 = (1 << 17);

        [NativeTypeName("#define RETRO_SIMD_POPCNT (1 << 18)")]
        public const int RETRO_SIMD_POPCNT = (1 << 18);

        [NativeTypeName("#define RETRO_SIMD_MOVBE (1 << 19)")]
        public const int RETRO_SIMD_MOVBE = (1 << 19);

        [NativeTypeName("#define RETRO_SIMD_CMOV (1 << 20)")]
        public const int RETRO_SIMD_CMOV = (1 << 20);

        [NativeTypeName("#define RETRO_SIMD_ASIMD (1 << 21)")]
        public const int RETRO_SIMD_ASIMD = (1 << 21);

        [NativeTypeName("#define RETRO_SENSOR_ACCELEROMETER_X 0")]
        public const int RETRO_SENSOR_ACCELEROMETER_X = 0;

        [NativeTypeName("#define RETRO_SENSOR_ACCELEROMETER_Y 1")]
        public const int RETRO_SENSOR_ACCELEROMETER_Y = 1;

        [NativeTypeName("#define RETRO_SENSOR_ACCELEROMETER_Z 2")]
        public const int RETRO_SENSOR_ACCELEROMETER_Z = 2;

        [NativeTypeName("#define RETRO_SENSOR_GYROSCOPE_X 3")]
        public const int RETRO_SENSOR_GYROSCOPE_X = 3;

        [NativeTypeName("#define RETRO_SENSOR_GYROSCOPE_Y 4")]
        public const int RETRO_SENSOR_GYROSCOPE_Y = 4;

        [NativeTypeName("#define RETRO_SENSOR_GYROSCOPE_Z 5")]
        public const int RETRO_SENSOR_GYROSCOPE_Z = 5;

        [NativeTypeName("#define RETRO_SENSOR_ILLUMINANCE 6")]
        public const int RETRO_SENSOR_ILLUMINANCE = 6;

        [NativeTypeName("#define RETRO_HW_FRAME_BUFFER_VALID ((void*)-1)")]
        public static readonly void* RETRO_HW_FRAME_BUFFER_VALID = unchecked((void*)(-1));

        [NativeTypeName("#define RETRO_NUM_CORE_OPTION_VALUES_MAX 128")]
        public const int RETRO_NUM_CORE_OPTION_VALUES_MAX = 128;

        [NativeTypeName("#define RETRO_MEMORY_ACCESS_WRITE (1 << 0)")]
        public const int RETRO_MEMORY_ACCESS_WRITE = (1 << 0);

        [NativeTypeName("#define RETRO_MEMORY_ACCESS_READ (1 << 1)")]
        public const int RETRO_MEMORY_ACCESS_READ = (1 << 1);

        [NativeTypeName("#define RETRO_MEMORY_TYPE_CACHED (1 << 0)")]
        public const int RETRO_MEMORY_TYPE_CACHED = (1 << 0);
    }
}
