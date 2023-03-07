### TC2005B CONSTRUCCION DE SOFTWARE Y TOMA DE DESICIONES (TC2005B) 
 
# ACTIVIDAD 1: 
## TORNEO INTERNACIONAL: Algebra relacional  
 
 
Escriba en álgebra relacional las siguientes consultas: 
 
### 1. Apellidos y nombre de los participantes de nacionalidad mexicana.  

**Respuesta:**

* $\prod$<sub>nombre, apellido </sub> ( $^\sigma$<sub>Nacionalidad= "MEX"</sub>(PARTICIPANTE))

### 2. Apellidos, nombre y puntos acumulados de los participantes de USA. 

**Respuesta:**

* $\prod$<sub>nombre, apellido, puntos</sub> ( $^\sigma$<sub>Nacionalidad= "USA"</sub>(PARTICIPANTE $\bowtie$ PUNTOSACUMULADOS)) 

### 3. Apellidos y nombre de los participantes que se clasificaron en primer lugar en al menos una 
competencia. 

**Respuesta:**

* $\prod$<sub>nombre, apellido</sub> ( $^\sigma$<sub>Lugar = 1 </sub>(PARTICIPANTE $\bowtie$ CLASIFICACION)) 

### 4. Nombre de las competencias en las que intervinieron los participantes mexicanos. 

**Respuesta:**

* $\prod$<sub>NombreCompetencia</sub> ( $^\sigma$<sub>Nacionalidad = "MEX" </sub>(PARTICIPANTE $\bowtie$ COMPETENCIA)) 

### 5. Apellidos y nombre de los participantes que nunca se clasificaron en primer lugar en alguna 
competencia.  

**Respuesta:**

* R1= $\prod$<sub>nombre,apellido</sub>(PARTICIPANTE)

* R2= $\prod$<sub>nombre,apellido</sub>  ($^\sigma$<sub>Lugar = 1</sub> (PARTICIPANTE $\bowtie$ COMPETENCIA))

* R1 - R2

### 6. Apellidos y nombre de los participantes siempre se clasificaron en alguna competencia.

**Respuesta:**

* R1= $\prod$<sub>nombre,apellido</sub>(PARTICIPANTE)

* R2= $\prod$<sub>nombre,apellido</sub>  ($^\sigma$<sub>Lugar = 1 or 2 or 3 </sub> (PARTICIPANTE $\bowtie$ COMPETENCIA))

* R1 $\bigcap$ R2

### 7. Nombre de la competencia que aporta el máximo de puntos. 

**Respuesta:**
Con base a la ppt que se encuentra en canvas mi solución es la siguiente: 

* R1= $\prod$<sub>NumPuntos,NombreCompetencia</sub>(COMPETENCIA)
* R2= $\prod$<sub>NumPuntos,NombreCompetencia</sub>(COMPETENCIA)
* R3= $\rho$<sub>tabla1</sub>(R1)
* R4= $\rho$<sub>tabla2</sub>(R2)
* R5= $\rho$<sub>c/n</sub>(R4)
* R6= R3 X R5
* R7=$\sigma$<sub>c<n</sub>(R6)
* R8= $\prod$<sub>(n)</sub>R7
* R9= R1-R8


### 8. Países (nacionalidades) que participaron en todas las competencias. 

**Respuesta:**
* R1= $\prod$<sub>nacionalidad </sub> (PARTICIPANTE)
* R2= $\prod$<sub>nacionalidad </sub> (PARTICIPANTE $\bowtie$ COMPETENCIA)
* R3 = R1 R2

Nota: tengo entendido que esto se resuelve con division, sin embargo no logre encontrar las notas al respecto por lo tanto lo dejo incompleto. 
