using Xunit;

namespace TestDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void calcularTiempoVueloTest()
    {
        //Arrange
        var distancia = 6;
        var velocidad = 250;
        var res= 1.44;
        //Act
        var resultado = Timer.calcularTiempoVuelo(distancia, velocidad);
        //Assert
        Assert.Equal(res,resultado);
    }
    [Fact]
    public void calcularTiempoVueloTest1()
    {
        //Arrange
        var distancia = 0;
        var velocidad = 0;
         var res= 0;
        //Act
        var resultado = Timer.calcularTiempoVuelo(distancia, velocidad);
        //Assert
        Assert.Equal(res,resultado);
    }
    [Fact]
    public void calcularTiempoVueloTest2()
    {
        //Arrange
        var distancia = 15;
        var velocidad = 220;
         var res= 4.09091;
        //Act
        var resultado = Timer.calcularTiempoVuelo(distancia, velocidad);
        //Assert
        Assert.Equal(res,resultado);
    }
    [Fact]    
    public void calcularTiempoVueloTest3()
    {
        //Arrange
        var distancia = 9999;
        var velocidad = 9999;
         var res=60;
        //Act
        var resultado = Timer.calcularTiempoVuelo(distancia, velocidad);
        //Assert
        Assert.Equal(res,resultado);
    }
    [Fact]
    public void calcularTiempoVueloTest4()
    {
        //Arrange
        var distancia = 4;
        var velocidad = 100;
         var res= 24;
        //Act
        var resultado = Timer.calcularTiempoVuelo(distancia, velocidad);
        //Assert
        Assert.Equal(res,resultado);
    }
    [Fact]
    public void calcularTiempoVueloTest5()
    {
        //Arrange
        var distancia = 7;
        var velocidad = 20;
         var res= 21;
        //Act
        var resultado = Timer.calcularTiempoVuelo(distancia, velocidad);
        //Assert
        Assert.Equal(res,resultado);
    }

    //----------------------------------------

    [Fact]
       public void calcularHoraLlegadaTest()
    {
        //Arrange
        var horaSalida = 8;
        var minutosSalida =15;
        var duracionVuelo = 45;
        var horas="9:0";
        //Act
        var resultado = Timer.calcularHoraLlegada(horaSalida,minutosSalida,duracionVuelo);
        //Assert
         Assert.Equal(horas,resultado);
    }
    public void calcularHoraLlegadaTest1()
    {
        //Arrange
        var horaSalida = 0;
        var minutosSalida =0;
        var duracionVuelo = 0;
        var horas="0:0";
        //Act
        var resultado = Timer.calcularHoraLlegada(horaSalida,minutosSalida,duracionVuelo);
        //Assert
         Assert.Equal(horas,resultado);
    }
    public void calcularHoraLlegadaTest2()
    {
        //Arrange
        var horaSalida = 20;
        var minutosSalida =15;
        var duracionVuelo = 400;
        var horas="2:55";
        //Act
        var resultado = Timer.calcularHoraLlegada(horaSalida,minutosSalida,duracionVuelo);
        //Assert
         Assert.Equal(horas,resultado);
    }
    public void calcularHoraLlegadaTest3()
    {
        //Arrange
        var horaSalida = 18;
        var minutosSalida =48;
        var duracionVuelo = 120;
        var horas="20:18";
        //Act
        var resultado = Timer.calcularHoraLlegada(horaSalida,minutosSalida,duracionVuelo);
        //Assert
         Assert.Equal(horas,resultado);
    }
    public void calcularHoraLlegadaTest4()
    {
        //Arrange
        var horaSalida = 4;
        var minutosSalida =5;
        var duracionVuelo = 0;
        var horas="4:5";
        //Act
        var resultado = Timer.calcularHoraLlegada(horaSalida,minutosSalida,duracionVuelo);
        //Assert
         Assert.Equal(horas,resultado);
    }
    public void calcularHoraLlegadaTest5()
    {
        //Arrange
        var horaSalida = 0;
        var minutosSalida =0;
        var duracionVuelo = 75;
        var horas="1:15";
        //Act
        var resultado = Timer.calcularHoraLlegada(horaSalida,minutosSalida,duracionVuelo);
        //Assert
         Assert.Equal(horas,resultado);
    }

//----------------------------------------
   
    public void convertirHorasTest()
    {
        //Arrange
        var horas = 0;
        var zonaHoraria =0;
        var hora=0;
        //Act
        var resultado = Timer.convertirHoras(horas,zonaHoraria);
        //Assert
        Assert.Equal(hora,resultado);
    }
    public void convertirHorasTest1()
    {
        //Arrange
        var horas = 27;
        var zonaHoraria =12;
        var hora=15;
        //Act
        var resultado = Timer.convertirHoras(horas,zonaHoraria);
        //Assert
        Assert.Equal(hora,resultado);
    }
    public void convertirHorasTest2()
    {
        //Arrange
        var horas = 5;
        var zonaHoraria =8;
       var hora=13;
        //Act
        var resultado = Timer.convertirHoras(horas,zonaHoraria);
        //Assert
        Assert.Equal(hora,resultado);
    }
    public void convertirHorasTest3()
    {
        //Arrange
        var horas = 70;
        var zonaHoraria =50;
        var hora=0;
        //Act
        var resultado = Timer.convertirHoras(horas,zonaHoraria);
        //Assert
        Assert.Equal(hora,resultado);
    }
    public void convertirHorasTest4()
    {
        //Arrange
        var horas = 5;
        var zonaHoraria =7;
        var hora=12;
        //Act
        var resultado = Timer.convertirHoras(horas,zonaHoraria);
        //Assert
        Assert.Equal(hora,resultado);
    }
    public void convertirHorasTest5()
    {
        //Arrange
        var horas = 9;
        var zonaHoraria =  -5;
        var hora=4;
        //Act
        var resultado = Timer.convertirHoras(horas,zonaHoraria);
        //Assert
        Assert.Equal(hora,resultado);
    }
    
}

    