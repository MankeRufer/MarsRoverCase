using HBMarsProject.Enum;
using HBMarsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsProject
{
    public class Rover
    {

        public int PositionX = 0;
        public int PositionY = 0;
        public DirectionEnum direction;
        public void setRoverPosition(Position pos)
        {
            this.PositionX = pos.X;
            this.PositionY = pos.Y;
            this.direction = pos.Direction;
        }


        public void TurnLeft()
        {

            int CurrentDirection = (int)direction;


            if ((CurrentDirection - 1) < (int)DirectionEnum.N)
            {
                this.direction = DirectionEnum.W;
            }
            else
            {
                this.direction = (DirectionEnum)(CurrentDirection - 1);
            }
        }

        public void TurnRight()
        {
            int CurrentDirection = (int)direction;

            if ((CurrentDirection + 1) > (int)DirectionEnum.W)
            {
                this.direction = DirectionEnum.N;
            }
            else
            {
                this.direction = (DirectionEnum)(CurrentDirection + 1);
            }
        }

        public void Move()
        {

            switch (this.direction)
            {
                case DirectionEnum.N:
                    this.PositionY += 1;
                    break;
                case DirectionEnum.E:
                    this.PositionX += 1;
                    break;
                case DirectionEnum.S:
                    this.PositionY -= 1;
                    break;
                case DirectionEnum.W:
                    this.PositionX -= 1;
                    break;
                default:
                    break;
            }
        }


        public void MoveDiscovery(Rover rover, string discovery, int CoordinateX, int CoordinateY)
        {
            var discoveryArray = discovery.ToCharArray();
            for (int i = 0; i < discoveryArray.Count(); i++)
            {
                if (discoveryArray[i] == 'L')
                {
                    rover.TurnLeft();
                }
                if (discoveryArray[i] == 'R')
                {
                    rover.TurnRight();
                }
                if (discoveryArray[i] == 'M')
                {
                    if (rover.ControlMove(CoordinateX, CoordinateY))
                    {
                        rover.Move();
                    }
                }
            }
        }


        public bool ControlMove(int CoordinateX, int CoordinateY)
        {


            if ((this.PositionX - 1) < 0 && this.direction == DirectionEnum.W)
            {
                return false;
            }

            if ((this.PositionX + 1) > (CoordinateX) && this.direction == DirectionEnum.E)
            {
                return false;
            }

            if ((this.PositionY + 1) > (CoordinateY) && this.direction == DirectionEnum.N)
            {
                return false;
            }
            if ((this.PositionY - 1) < 0 && this.direction == DirectionEnum.S)
            {
                return false;
            }

            return true;


        }



    }
}
