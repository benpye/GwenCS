using System;
using System.Collections.Generic;
using System.Text;

namespace Gwen.Compat
{
    public class Cursor
    {
        private CursorsInternal cursorType;

        internal Cursor(CursorsInternal cursorType)
        {
            this.cursorType = cursorType;
        }

        public static Cursor Current { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Cursor c) return c.cursorType == this.cursorType;
            return false;
        }

        public override string ToString()
        {
            return cursorType.ToString();
        }

        public override int GetHashCode()
        {
            return cursorType.GetHashCode();
        }
    }
    internal enum CursorsInternal
    {
        AppStarting,
        Arrow,
        Cross,
        Default,
        Hand,
        Help,
        HSplit,
        IBeam,
        No,
        NoMove2D,
        NoMoveHoriz,
        NoMoveVert,
        PanEast,
        PanNE,
        PanNorth,
        PanNW,
        PanSE,
        PanSouth,
        PanSW,
        PanWest,
        SizeAll,
        SizeNESW,
        SizeNS,
        SizeNWSE,
        SizeWE,
        UpArrow,
        VSplit,
        WaitCursor
    }
}
