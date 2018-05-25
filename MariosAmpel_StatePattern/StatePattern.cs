using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MariosAmpel_StatePattern
{
    class StatePattern
    {
        //nur der Dateibezeichner, wird nicht benötigt
        //Definition weiter unten
    }

    //StateContext, die wichtigste Klasse
    public class StateContext
    {
        public Color AmpelOben { get; set; }
        public Color AmpelMitte{ get; set; }
        public Color AmpelUnten { get; set; }
        public IState State { get; set; }

        //Methode zum Wechseln des Status
        public void Change()
        {
            State.Change(this);
        }

    }

    //Interface State
    public interface IState
    {
        void Change(StateContext context);
    }


    //State A
    public class Red : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new RedAndAmber();
            objekt.AmpelOben = Color.Red;
            objekt.AmpelMitte = Color.Yellow;
            objekt.AmpelUnten = Color.Black;
        }
    }

    //State B
    public class RedAndAmber : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new Green();
            objekt.AmpelOben = Color.Black;
            objekt.AmpelMitte = Color.Black;
            objekt.AmpelUnten = Color.LimeGreen;
        }
    }

    //State C
    public class Yellow : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new Red();
            objekt.AmpelOben = Color.Red;
            objekt.AmpelMitte = Color.Black;
            objekt.AmpelUnten = Color.Black;
        }
    }

    //State D
    public class Green : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new Yellow();
            objekt.AmpelOben = Color.Black;
            objekt.AmpelMitte = Color.Yellow;
            objekt.AmpelUnten = Color.Black;
        }
    }
}
