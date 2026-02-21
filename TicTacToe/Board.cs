using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private State[,] state;
        public  State NextTurn { get; private set; }

        public Board() {
            state=new State[3,3];
            NextTurn = State.x;
        
        }

        public State GetState(Position position) {
            return state[position.Row,position.Column];
        }
        public bool SetState(Position position,State newState)
        {
            if (newState != NextTurn) return false;
            if (state[position.Row, position.Column]!=State.undecided) return false;
            state[position.Row, position.Column]=newState;
            return true;
        }

        public void SwitchNextTurn()
        {
            if (NextTurn == State.x) NextTurn = State.o;
            else NextTurn = State.x;
        }

    }
}
