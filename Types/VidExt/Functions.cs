using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types.VidExt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Functions
    {
        uint FunctionCount;

        public delegate Error VidExtFuncInitDelegate();
        public VidExtFuncInitDelegate Init;

        public delegate Error VidExtFuncQuitDelegate();
        public VidExtFuncQuitDelegate Quit;

        public delegate Error VidExtFuncListModesDelegate(ref Size2D resultArray, ref int size);
        public VidExtFuncSetModeDelegate ListModes;

        public delegate Error VidExtFuncSetModeDelegate(int width, int height, int bpp, VideoMode screenMode, VideoFlags flags);
        public VidExtFuncSetModeDelegate SetMode;

        public delegate IntPtr VidExtFuncGLGetProcDelegate(IntPtr proc);
        public VidExtFuncGLGetProcDelegate GLGetProc;

        public delegate Error VidExtFuncGLSetAttributeDelegate(GLAttribute attribute, int value);
        public VidExtFuncGLSetAttributeDelegate GLSetAttribute;

        public delegate Error VidExtFuncGLGetAttributeDelegate(GLAttribute attribute, ref int value);
        public VidExtFuncGLGetAttributeDelegate GLGetAttribute;

        public delegate Error VidExtFuncGLSwapBuffersDelegate();
        public VidExtFuncGLSwapBuffersDelegate GLSwapBuffers;

        public delegate Error VidExtFuncSetCaptionDelegate([MarshalAs(UnmanagedType.LPStr)]string title);
        public VidExtFuncSetCaptionDelegate SetCaption;

        public delegate Error VidExtFuncToggleFSDelegate();
        public VidExtFuncToggleFSDelegate ToggleFS;

        public delegate Error VidExtFuncResizeWindow(int width, int height);
        public VidExtFuncResizeWindow ResizeWindow;

        public delegate uint VidExtFuncGLGetDefaultFramebuffer();
        public VidExtFuncGLGetDefaultFramebuffer GetDefaultFramebuffer;
    }
}