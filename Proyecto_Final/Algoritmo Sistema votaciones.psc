Algoritmo Votaciones
	Definir vc1, vc2, vc3, vn, f, ver Como Entero 
	Dimension votantes[100] 
	f <- 0
	ver <- 0
	vc1 <- 0
	vc2 <- 0
	vc3 <- 0
	vn <- 0
	Mientras (f==0) hacer
		Escribir "Ingrese una identificacion para registrar"
		Escribir "o Ingrese 0 para ver los resultados"
		leer v
		Si (v <> 0) Entonces
			Para i<-1 Hasta 100 Con Paso 1 Hacer
				Si (votantes[i]==v) Entonces
					ver = 1;
				Sino
					ver = 0;
					votantes[i]<-v
				Fin Si
			Fin Para
			si(ver==1) entonces
				Limpiar Pantalla
				Escribir "¡Esta persona no puede votar dos veces!"
			Sino
				Limpiar Pantalla
				Escribir "____Seleccione un candidato____"
				Escribir "1. Pedro"
				Escribir "2. Pablo"
				Escribir "3. Luisa"
				Escribir "Elija por quien votar segun el posicionamiento"
				leer voto
				Segun voto Hacer
					1:
						vc1 <- vc1 + 1
					2:
						vc2 <- vc2 + 1
					3:
						vc3 <- vc3 + 1
					De Otro Modo:
						vn <- vn + 1
				Fin Segun
			FinSi
		Sino
			Escribir "*** Resultados de las elecciones ***"
				si(vc1>vc2 y vc1>vc3) entonces
					Escribir "El ganador es Pedro con ",vc1," votos"
					si(vc2>vc3) entonces
						Escribir "Pablo tiene ",vc2," votos"
						Escribir "Luisa tiene ",vc3," votos"
					Sino
						Escribir "Luisa tiene ",vc3," votos"
						Escribir "Pablo tiene ",vc2," votos"
					FinSi
				Sino
					si (vc2>vc1 y vc2>vc3) entonces
						Escribir "El ganador es Pablo con ",vc2," votos"
						
						si(vc1>vc3) entonces
							Escribir "Pedro tiene ",vc1," votos"
							Escribir "Luisa tiene ",vc3," votos"
						Sino
							Escribir "Luisa tiene ",vc3," votos"
							Escribir "Pedro tiene ",vc1," votos"
						FinSi
					Sino
						si (vc3>vc1 y vc3>vc2) entonces
							Escribir "El ganador fué Luisa con ",vc3," votos"
							si(vc2>vc1) entonces
								Escribir "Pablo tiene ",vc2," votos"
								Escribir "Pedro tiene ",vc1," votos"
							Sino
								Escribir "Pedro tiene ",vc1," votos"
								Escribir "Pablo tiene ",vc2," votos"
							FinSi	
						Sino
							Escribir "Existe un empate entre candidatos, se deben repetir las elecciones"
					FinSi
				FinSi
			FinSi
			Escribir "Votos No válidos: ",vn
			f<-1
			Fin Si
	FinMientras
FinAlgoritmo
