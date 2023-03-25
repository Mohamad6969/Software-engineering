using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeGame;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SnakeNUnitTests
{
    [TestClass]
    public class SnakeGameTests
    {
        [SetUp]
        private GridValue gridvalue_Empty;
        private GridValue gridvalue_Snake;
        private GridValue gridvalue_Outside;
        public void SetUp()
        {
            // ARRANGE
            gridvalue_Empty = new GridValue();

            // ARRANGE
            gridvalue_Snake = new GridValue();

            // ARRANGE
            gridvalue_Outside = new GridValue();
        }
        
          



        [TestMethod]
        public void Adding_Food_inGrid()
        {
            



            // act

            if (gridvalue_Empty == GridValue.Empty)
            {
                gridvalue_Empty = GridValue.Food;
            }
            

            // ASSERT
            Assert.AreEqual(GridValue.Food, gridvalue_Empty);

        }

        [TestMethod]
        public void Spawning_Snake()
        {
            


            // act
            if(gridvalue_Snake == 0)
            {
                gridvalue_Snake = GridValue.Snake;
            }

            

            // ASSERT
            Assert.AreEqual(GridValue.Snake, gridvalue_Snake);

        }

        [TestMethod]
        public void Spawning_OutsideGrid()
        {
          


            // act
            if (gridvalue_Outside == 0)
            {
                gridvalue_Outside = GridValue.Outside;
            }



            // ASSERT
            Assert.AreEqual(GridValue.Outside, gridvalue_Outside);

        }

       

    }
}
