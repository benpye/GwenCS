using System;
using System.Collections.Generic;
using System.Text;

namespace Gwen.Compat
{
    public class Cursors
    {
        public static Cursor AppStarting => new Cursor(CursorsInternal.AppStarting);
        public static Cursor Arrow => new Cursor(CursorsInternal.Arrow);
        public static Cursor Cross => new Cursor(CursorsInternal.Cross);
        public static Cursor Default => new Cursor(CursorsInternal.Default);
        public static Cursor Hand => new Cursor(CursorsInternal.Hand);
        public static Cursor Help => new Cursor(CursorsInternal.Help);
        public static Cursor HSplit => new Cursor(CursorsInternal.HSplit);
        public static Cursor IBeam => new Cursor(CursorsInternal.IBeam);
        public static Cursor No => new Cursor(CursorsInternal.No);
        public static Cursor NoMove2D => new Cursor(CursorsInternal.NoMove2D);
        public static Cursor NoMoveHoriz => new Cursor(CursorsInternal.NoMoveHoriz);
        public static Cursor NoMoveVert => new Cursor(CursorsInternal.NoMoveVert);
        public static Cursor PanEast => new Cursor(CursorsInternal.PanEast);
        public static Cursor PanNE => new Cursor(CursorsInternal.PanNE);
        public static Cursor PanNorth => new Cursor(CursorsInternal.PanNorth);
        public static Cursor PanNW => new Cursor(CursorsInternal.PanNW);
        public static Cursor PanSE => new Cursor(CursorsInternal.PanSE);
        public static Cursor PanSouth => new Cursor(CursorsInternal.PanSouth);
        public static Cursor PanSW => new Cursor(CursorsInternal.PanSW);
        public static Cursor PanWest => new Cursor(CursorsInternal.PanWest);
        public static Cursor SizeAll => new Cursor(CursorsInternal.SizeAll);
        public static Cursor SizeNESW => new Cursor(CursorsInternal.SizeNESW);
        public static Cursor SizeNS => new Cursor(CursorsInternal.SizeNS);
        public static Cursor SizeNWSE => new Cursor(CursorsInternal.SizeNWSE);
        public static Cursor SizeWE => new Cursor(CursorsInternal.SizeWE);
        public static Cursor UpArrow => new Cursor(CursorsInternal.UpArrow);
        public static Cursor VSplit => new Cursor(CursorsInternal.VSplit);
        public static Cursor WaitCursor => new Cursor(CursorsInternal.WaitCursor);
    }

}
