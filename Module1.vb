'Imports System.Runtime.Remoting.Messaging
'Imports System.Security.Cryptography.X509Certificates

Module Module1

    Sub Main()
        Console.Write("/º_-_-_-_-_-_-_-_-_-_-_-_-_-  WELCOME MY PROYECT  _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-º\")
        Console.WriteLine()
        Console.Write("Guia Nº1 De Programacion ll, Con Ponderacion del 20% para labopratprio 2.")
        Console.WriteLine()
        Console.Write("Realizado Por: José Rigoberto Medoza Rivas")
        Console.WriteLine()

        Proyecto1()
        'Proyecto2()
        'Proyecto3()
        'Proyecto4()




    End Sub

    Sub Proyecto1()
        Try
            Console.WriteLine()
            Console.WriteLine("DESARROLLO DE PROYECTO 1")
            Console.WriteLine()

            ' Solicitar al usuario la distancia en kilómetros, horas y minutos
            Console.Write("Ingrese la distancia en kilómetros: ")
            Dim distanciaKm As Double = Double.Parse(Console.ReadLine())

            Console.Write("Ingrese el tiempo en horas: ")
            Dim horas As Integer = Integer.Parse(Console.ReadLine())

            Console.Write("Ingrese el tiempo en minutos: ")
            Dim minutos As Integer = Integer.Parse(Console.ReadLine())

            ' Calcular el tiempo total en minutos
            Dim tiempoTotalMinutos As Integer = (horas * 60) + minutos

            ' Calcular la velocidad media en diferentes unidades
            Dim velocidadKmPorHora As Double
            velocidadKmPorHora = distanciaKm / horas

            Dim velocidadKmPorMinuto As Double
            velocidadKmPorMinuto = distanciaKm / tiempoTotalMinutos

            Dim velocidadKmPorSegundo As Double
            velocidadKmPorSegundo = distanciaKm / (tiempoTotalMinutos * 60)

            Dim velocidadMPorMinuto As Double
            velocidadMPorMinuto = (distanciaKm * 1000) / tiempoTotalMinutos

            Dim velocidadMPorSegundo As Double
            velocidadMPorSegundo = (distanciaKm * 1000) / (tiempoTotalMinutos * 60)

            ' Mostrar los resultados en consola
            Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora & " Km/h")
            Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto & " Km/min")
            Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo & " Km/s")
            Console.WriteLine("Velocidad media en m/min: " & velocidadMPorMinuto & " m/min")
            Console.WriteLine("Velocidad media en m/s: " & velocidadMPorSegundo & " m/s")

        Catch ex As Exception
        Finally
            Console.WriteLine()
            Console.WriteLine("Presione Enter para salir...")
            Console.ReadLine()
        End Try

        Console.ReadLine() ' Esperar a que el usuario presione Enter antes de cerrar la aplicación


    End Sub

    Sub Proyecto2()

        Try
            Console.WriteLine()
            Console.Write("DESARROLLO DE PROYECTO 2")
            Console.WriteLine()
            Console.WriteLine("Ingrese el promedio mensual de infracciones: ")
            Dim promedioMensual As Double
            promedioMensual = Double.Parse(Console.ReadLine())

            ' Calcular el promedio diario en diferentes jornadas
            Dim promedioMatutino As Double
            promedioMatutino = (promedioMensual * 0.2) / 30

            Dim promedioTarde As Double
            promedioTarde = (promedioMensual * 0.35) / 30

            Dim promedioNocturno As Double
            promedioNocturno = (promedioMensual * 0.45) / 30

            ' Imprimir resultados
            Console.WriteLine("Promedio diario de infracciones en la mañana: " & promedioMatutino.ToString("F2"))
            Console.WriteLine("Promedio diario de infracciones en la tarde: " & promedioTarde.ToString("F2"))
            Console.WriteLine("Promedio diario de infracciones en la noche: " & promedioNocturno.ToString("F2"))
        Catch ex As FormatException
            Console.WriteLine("Error de formato: Ingrese un valor numérico válido.")
        Finally
            Console.WriteLine()
            Console.WriteLine("Presione Enter para salir...")
            Console.ReadLine()
        End Try
        Console.ReadLine() ' Esperar a que el usuario presione Enter antes de cerrar la aplicación

    End Sub



    Sub Proyecto3()
        Try
            Console.WriteLine()
            Console.Write("DESARROLLO DE PROYECTO 3")
            Console.WriteLine()

            Dim NI As Integer
            Dim N2 As Integer

            Console.Write("Inserta el primer número: ")
            NI = Convert.ToInt32(Console.ReadLine())

            Console.Write("Inserta el segundo número: ")
            N2 = Convert.ToInt32(Console.ReadLine())

            If NI Mod N2 = 0 Then
                Console.WriteLine(N2 & " es un divisor de " & NI)
            ElseIf N2 Mod NI = 0 Then
                Console.WriteLine(NI & " es un divisor de " & N2)
            Else
                Console.WriteLine("Ninguno de los números es divisor del otro.")
            End If

            Console.ReadLine()

        Catch ex As Exception
        Finally
            Console.WriteLine()
            Console.WriteLine("Presione Enter para salir...")
            Console.ReadLine()
        End Try
        Console.ReadLine() ' Esperar a que el usuario presione Enter antes de cerrar la aplicación

    End Sub

    Sub Proyecto4()
        Try
            Console.WriteLine()
            Console.Write("DESARROLLO DE PROYECTO 4")
            Console.WriteLine()

            Dim random As New Random

            Dim numero1 As Integer = random.Next()
            Dim numero2 As Integer = random.Next()
            Dim numero3 As Integer = random.Next()

            Console.WriteLine("Ingrese el primer número:")
            numero1 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el segundo número:")
            numero2 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el tercer número:")
            numero3 = Convert.ToInt32(Console.ReadLine)

            Dim mayor As Integer
            mayor = Math.Max(numero1, Math.Max(numero2, numero3))
            Dim menor As Integer
            menor = Math.Min(numero1, Math.Min(numero2, numero3))
            Dim medio As Integer
            medio = (numero1 + numero2 + numero3 - mayor - menor)

            Console.WriteLine("Random: {0},{1},{2} ", numero1, numero2, numero3)

            Console.WriteLine("El número mayor es: {0}", mayor)
            Console.WriteLine("El número medio es: {0}", medio)
            Console.WriteLine("El número menor es: {0}", menor)

            Console.ReadLine()

        Catch ex As Exception
        Finally
            Console.WriteLine()
            Console.WriteLine("Presione Enter para salir...")
            Console.ReadLine()
        End Try
        Console.ReadLine() ' Esperar a que el usuario presione Enter antes de cerrar la aplicación

    End Sub

End Module
