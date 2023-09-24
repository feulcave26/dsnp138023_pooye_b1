Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program
    Function greetings()
        Console.Clear()
        Console.WriteLine("dsnp138023_Fernando Ulises Campos Ventura")
        Console.WriteLine()
        Console.WriteLine("universidad Gerardo Barrios")
        Console.WriteLine("ingeniería en desarrollo de software")
        Console.WriteLine("bloque 1_actividad 1_programación ¿qué nos ofrece?")
        Console.WriteLine()
        Return 0
    End Function
    Function filter_number(value_to_filter As String, num_low As Int64, num_max As Int64, error_msj As String, return_type As String)
        While (IsNumeric(value_to_filter) = False)
            Console.Write(error_msj)
            value_to_filter = Console.ReadLine()

        End While
        While (value_to_filter < num_low Or value_to_filter > num_max)
            Console.Write(error_msj)
            value_to_filter = Console.ReadLine()
        End While
        If (return_type = "sbyte") Then
            Return SByte.Parse(value_to_filter)
        ElseIf (return_type = "int16") Then
            Return Int16.Parse(value_to_filter)
        ElseIf (return_type = "int32") Then
            Return Int32.Parse(value_to_filter)
        ElseIf (return_type = "int64") Then
            Return Int64.Parse(value_to_filter)
        ElseIf (return_type = "double") Then
            Return Double.Parse(value_to_filter)
        End If
    End Function
    Sub Main(args As String())
        Dim main1 As SByte
        Dim main2 As SByte
        Dim main2_string As String

        Do
            greetings()
            Console.WriteLine("opciones disponibles:")
            Console.WriteLine()
            Console.WriteLine("        1-determinar si es mayor o menor de edad en base a su edad")
            Console.WriteLine("        2-determinar si un número es negativo o positivo")
            Console.WriteLine("        3-determinar el total a pagar y el descuento aplicado, en base al monto de la compra")
            Console.WriteLine("        4-determine la suma de los números naturales desde 1 hasta n")
            Console.WriteLine("        5-despliegue la tabla de multiplicar de un número ingresado por el usario")
            Console.WriteLine()
            Console.WriteLine("        0-salir del programa")
            Console.WriteLine()
            Console.Write("por favor ingrese el número de programa a ejecutar: ")
            main2_string = Console.ReadLine()
            main2 = filter_number(main2_string, 0, 5, "        opción inválida, por favor inténtelo nuevamente: ", "sbyte")
            Select Case main2
                Case 0
                    main1 = 0
                Case 1
                    Do
                        Dim age As SByte
                        Dim age_string As String

                        greetings()
                        Console.WriteLine("programa 1: determinar si es mayor o menor de edad en base a su edad")
                        Console.WriteLine()
                        Console.Write("por favor ingrese la edad del usuario: ")
                        age_string = Console.ReadLine()
                        age = filter_number(age_string, 0, 150, "        dato inválido, por favor ingrese una edad verídica: ", "sbyte")
                        If (age < 18) Then
                            Console.WriteLine()
                            Console.WriteLine("el usuario es menor de edad")
                        Else
                            Console.WriteLine()
                            Console.WriteLine("el usuario es mayor de edad")
                        End If
                        Console.WriteLine()
                        Console.WriteLine("seleccione una de las siguientes opciones:")
                        Console.WriteLine()
                        Console.WriteLine("        1-repetir el programa actual")
                        Console.WriteLine("        2-salir al menu principal")
                        Console.WriteLine()
                        Console.WriteLine("        0-salir del programa por completo")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número de opción a ejecutar: ")
                        main2_string = Console.ReadLine()
                        main2 = filter_number(main2_string, 0, 2, "        opción inválida, por favor inténtelo nuevamente: ", "sbyte")
                        Select Case main2
                            Case 0
                                main1 = 0
                                main2 = 0
                            Case 1
                                main2 = 1
                            Case 2
                                main1 = 1
                                main2 = 0
                        End Select
                    Loop Until (main2 <> 1)
                Case 2
                    Do
                        Dim num As Double
                        Dim num_string As String

                        greetings()
                        Console.WriteLine("programa 2: determinar si un número es negativo o positivo")
                        Console.WriteLine("por cuestiones técnicas se ha limitado el rango de valores de -1000 a 1000")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número a evaluar: ")
                        num_string = Console.ReadLine()
                        num = filter_number(num_string, -1000000, 1000000, "        dato inválido, por favor ingrese solo valores númericos dentro del rango: ", "double")
                        If (num = 0) Then
                            Console.WriteLine()
                            Console.WriteLine("el número ingresado es 0, por lo cual no tiene signo")
                        ElseIf (num < 0) Then
                            Console.WriteLine()
                            Console.WriteLine("el número ingresado es " & num & ", el cual es un número negativo")
                        ElseIf (num > 0) Then
                            Console.WriteLine()
                            Console.WriteLine("el número ingresado es " & num & ", el cual es un número positivo")
                        End If
                        Console.WriteLine()
                        Console.WriteLine("seleccione una de las siguientes opciones:")
                        Console.WriteLine()
                        Console.WriteLine("        1-repetir el programa actual")
                        Console.WriteLine("        2-salir al menu principal")
                        Console.WriteLine()
                        Console.WriteLine("        0-salir del programa por completo")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número de opción a ejecutar: ")
                        main2_string = Console.ReadLine()
                        main2 = filter_number(main2_string, 0, 2, "        opción inválida, por favor inténtelo nuevamente: ", "sbyte")
                        Select Case main2
                            Case 0
                                main1 = 0
                                main2 = 0
                            Case 1
                                main2 = 1
                            Case 2
                                main1 = 1
                                main2 = 0
                        End Select
                    Loop Until (main2 <> 1)
                Case 3
                    Do
                        Dim price As Double
                        Dim price_string As String

                        greetings()
                        Console.WriteLine("programa 3: determinar el total a pagar y el descuento aplicado, en base al monto de la compra")
                        Console.WriteLine()
                        Console.WriteLine("a continuación se presenta la tabla de descuentos aplicables:")
                        Console.WriteLine()
                        Console.WriteLine("        |     total de factura     | descuento |")
                        Console.WriteLine("         -------------------------- -----------")
                        Console.WriteLine("        |   de $1000 en adelante   |    30%    |")
                        Console.WriteLine("        | de $500.00 hasta $999.99 |    20%    |")
                        Console.WriteLine("        | de $250.00 hasta $499.99 |    10%    |")
                        Console.WriteLine("        |  de $0.00 hasta $249.99  |    05%    |")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el valor total de la compra: $")
                        price_string = Console.ReadLine()
                        price = filter_number(price_string, 0, 1000000, "        dato inválido, por favor ingrese solo precios reales: $", "double")
                        If (price < 250) Then
                            Console.WriteLine()
                            Console.WriteLine("valor de la compra $" & Format(price, "0.00"))
                            Console.WriteLine("porcentaje de descuento 5%, valor de descuento $" & Format((price * 0.05), "0.00"))
                            Console.WriteLine()
                            Console.WriteLine("valor final $" & Format((price * 0.95), "0.00"))
                        ElseIf (price < 500) Then
                            Console.WriteLine()
                            Console.WriteLine("valor de la compra $" & Format(price, "0.00"))
                            Console.WriteLine("porcentaje de descuento 10%, valor de descuento $" & Format((price * 0.1), "0.00"))
                            Console.WriteLine()
                            Console.WriteLine("valor final $" & Format((price * 0.9), "0.00"))
                        ElseIf (price < 1000) Then
                            Console.WriteLine()
                            Console.WriteLine("valor de la compra $" & Format(price, "0.00"))
                            Console.WriteLine("porcentaje de descuento 20%, valor de descuento $" & Format((price * 0.2), "0.00"))
                            Console.WriteLine()
                            Console.WriteLine("valor final $" & Format((price * 0.8), "0.00"))
                        Else
                            Console.WriteLine()
                            Console.WriteLine("valor de la compra $" & Format(price, "0.00"))
                            Console.WriteLine("porcentaje de descuento 30%, valor de descuento $" & Format((price * 0.3), "0.00"))
                            Console.WriteLine()
                            Console.WriteLine("valor final $" & Format((price * 0.7), "0.00"))
                        End If
                        Console.WriteLine()
                        Console.WriteLine("seleccione una de las siguientes opciones:")
                        Console.WriteLine()
                        Console.WriteLine("        1-repetir el programa actual")
                        Console.WriteLine("        2-salir al menu principal")
                        Console.WriteLine()
                        Console.WriteLine("        0-salir del programa por completo")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número de opción a ejecutar: ")
                        main2_string = Console.ReadLine()
                        main2 = filter_number(main2_string, 0, 2, "        opción inválida, por favor inténtelo nuevamente: ", "sbyte")
                        Select Case main2
                            Case 0
                                main1 = 0
                                main2 = 0
                            Case 1
                                main2 = 1
                            Case 2
                                main1 = 1
                                main2 = 0
                        End Select
                    Loop Until (main2 <> 1)
                Case 4
                    Do
                        Dim num As Int64
                        Dim total As Double = 0
                        Dim num_string As String

                        greetings()
                        Console.WriteLine("programa 4: determine la suma de los números naturales desde 1 hasta n")
                        Console.WriteLine("nota: para efectos prácticos se ha configurado 999999999 como el valor máximo a ingresar")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número POSITIVO hasta el cual se hara la suma: ")
                        num_string = Console.ReadLine()
                        num = filter_number(num_string, 0, 999999999, "        dato inválido, por favor ingrese un valor númerico positivo: ", "int64")
                        For i As Int64 = 0 To num
                            total = total + i
                        Next
                        Console.WriteLine()
                        Console.WriteLine("la suma total de los primeros " & num & " números naturales es " & total)
                        Console.WriteLine()
                        Console.WriteLine("seleccione una de las siguientes opciones:")
                        Console.WriteLine()
                        Console.WriteLine("        1-repetir el programa actual")
                        Console.WriteLine("        2-salir al menu principal")
                        Console.WriteLine()
                        Console.WriteLine("        0-salir del programa por completo")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número de opción a ejecutar: ")
                        main2_string = Console.ReadLine()
                        main2 = filter_number(main2_string, 0, 2, "        opción inválida, por favor inténtelo nuevamente: ", "sbyte")
                        Select Case main2
                            Case 0
                                main1 = 0
                                main2 = 0
                            Case 1
                                main2 = 1
                            Case 2
                                main1 = 1
                                main2 = 0
                        End Select
                    Loop Until (main2 <> 1)
                Case 5
                    Do
                        Dim num As Int64
                        Dim num_string As String

                        greetings()
                        Console.WriteLine("programa 4: despliegue la tabla de multiplicar de un número ingresado por el usario")
                        Console.WriteLine("nota: para efectos prácticos se ha configurado 999999999 como el valor máximo a ingresar")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número POSITIVO del cual se desplegará la tabla de multiplicar: ")
                        num_string = Console.ReadLine()
                        num = filter_number(num_string, 0, 999999999, "        dato inválido, por favor ingrese un valor númerico positivo: ", "int64")
                        Console.WriteLine()
                        For i As Int64 = 0 To 9
                            Console.WriteLine(num & " x " & Format((i + 1), "00") & " = " & (num * (i + 1)))
                        Next
                        Console.WriteLine()
                        Console.WriteLine("seleccione una de las siguientes opciones:")
                        Console.WriteLine()
                        Console.WriteLine("        1-repetir el programa actual")
                        Console.WriteLine("        2-salir al menu principal")
                        Console.WriteLine()
                        Console.WriteLine("        0-salir del programa por completo")
                        Console.WriteLine()
                        Console.Write("por favor ingrese el número de opción a ejecutar: ")
                        main2_string = Console.ReadLine()
                        main2 = filter_number(main2_string, 0, 2, "        opción inválida, por favor inténtelo nuevamente: ", "sbyte")
                        Select Case main2
                            Case 0
                                main1 = 0
                                main2 = 0
                            Case 1
                                main2 = 1
                            Case 2
                                main1 = 1
                                main2 = 0
                        End Select
                    Loop Until (main2 <> 1)
            End Select
        Loop Until (main1 = 0)
    End Sub
End Module