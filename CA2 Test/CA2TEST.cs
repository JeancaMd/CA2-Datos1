namespace CA2_Test
{
    [TestClass]
    public sealed class CA2TEST
    {
        [TestMethod]
        public void InsertStartTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();

            //Act
            lista.InsertStart(20);

            //Assert
            Assert.AreEqual(1, lista.GetSize(), "La lista solo tiene al elemento 20");
            Assert.AreEqual("20", lista.ToString(), "La lista es solamente el 20");
        }

        [TestMethod]
        public void InsertEndTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);

            //Act
            lista.InsertEnd(40);

            //Assert
            Assert.AreEqual(2, lista.GetSize(), "La lista 2 elementos");
            Assert.AreEqual("20,40", lista.ToString(), "Se agregó el 40 al final de la lista");
        }

        [TestMethod]
        public void InsertAtTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);
            lista.InsertEnd(40);

            //Act
            lista.InsertAt(100, 1);

            //Assert
            Assert.AreEqual(3, lista.GetSize(), "La lista 3 elementos");
            Assert.AreEqual("20,100,40", lista.ToString(), "Se agregó el 100 en la posicion 1 de la lista");
        }

        [TestMethod]
        public void DeleteStartTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);
            lista.InsertEnd(40);

            //Act
            lista.DeleteStart();

            //Assert
            Assert.AreEqual(1, lista.GetSize(), "La lista 1 elemento");
            Assert.AreEqual("40", lista.ToString(), "Se elimina el primer elemento de la lista");
        }

        [TestMethod]
        public void DeleteEndTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);
            lista.InsertEnd(40);

            //Act
            lista.DeleteEnd();

            //Assert
            Assert.AreEqual(1, lista.GetSize(), "La lista 1 elemento");
            Assert.AreEqual("20", lista.ToString(), "Se elimina el ultimo elemento de la lista");
        }


        [TestMethod]
        public void DeleteAtTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);
            lista.InsertEnd(30);
            lista.InsertEnd(40);
            
            //Act
            lista.DeleteAt(1);

            //Assert
            Assert.AreEqual(2, lista.GetSize(), "La lista 2 elementos");
            Assert.AreEqual("20,40", lista.ToString(), "Se elimina el elemento en la posicion 1");
        }

        [TestMethod]
        public void GetSizeTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);
            lista.InsertEnd(30);

            //Assert
            Assert.AreEqual(2, lista.GetSize(), "La lista 2 elementos");
        }

        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            CircularLinkedList lista = new CircularLinkedList();
            lista.InsertStart(20);
            lista.InsertEnd(30);
            lista.InsertEnd(40);

            //Assert
            Assert.AreEqual("20,30,40", lista.ToString(), "La lista se convierte en strings");
        }
    }
}
