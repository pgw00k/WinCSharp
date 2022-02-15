using System.Runtime.InteropServices;

namespace WINAPI
{
	#region RECT
	[StructLayout(LayoutKind.Sequential)]
	public struct Rect
	{
		public int left;
		public int top;
		public int right;
		public int bottom;

        public override string ToString()
        {
			string r = $"({top},{bottom},{left},{right})";
			return r;
        }
    }
	#endregion
}
