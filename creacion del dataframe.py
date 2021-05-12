#Creacion de la base de datos 

#se importan librerias
import pandas as pd

#importacion de dataframes mas pequeños con sus especificaciones
rojo=pd.read_csv('C:/Users/Camilo/Desktop/Tesis 2/winequality-red.csv', sep=';')
blanco=pd.read_csv('C:/Users/Camilo/Desktop/Tesis 2/winequality-white.csv', sep=';')
#clasificacion
rojo["Clasificacion"]=1
blanco["Clasificacion"]=0
#creacion de dataframe a usar
vinos=pd.concat([rojo,blanco],axis=0)
vinos=vinos.reset_index()
vinos.drop('index',axis=1,inplace=True)
#Guardar el dataframe
vinos.to_csv('C:/Users/Camilo/Desktop/Tesis 2/vinos.csv')

vinos.columns
