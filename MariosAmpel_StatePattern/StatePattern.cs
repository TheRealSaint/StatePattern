using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }

    //State B
    public class RedAndAmber : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new Green();
        }
    }

    //State C
    public class Yellow : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new Red();
        }
    }

    //State D
    public class Green : IState
    {
        public void Change(StateContext objekt)
        {
            objekt.State = new Yellow();
        }
    }
}
