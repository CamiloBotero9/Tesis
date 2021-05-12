#importar librerias
import pandas as pd
from sklearn.tree import DecisionTreeClassifier
from sklearn.model_selection import train_test_split
from sklearn.metrics import confusion_matrix
from sklearn import metrics

#cargar base de datos
vinos=pd.read_csv('C:/Users/Camilo/Desktop/Tesis 2/vinos.csv', sep=',')

#eliminar index
vinos.drop('Unnamed: 0',axis=1,inplace=True)

#ver columnas del dataframe
vinos.columns

#datos a entregar
x=vinos[['fixed acidity', 'volatile acidity', 'citric acid', 'residual sugar',
       'chlorides', 'free sulfur dioxide', 'total sulfur dioxide', 'density',
       'pH', 'sulphates', 'alcohol', 'quality']]

#etiqueta
y=vinos["Clasificacion"] 

#particion de datos
x_train,x_text,y_train,y_text=train_test_split(x,y,random_state=3)

#variable de decision
dt=DecisionTreeClassifier()

#entrenarlas
dt.fit(x_train,y_train)

#predecir
y_pred=dt.predict(x_text)

#ver exacitud de los resultados
exactitud=metrics.accuracy_score(y_text,y_pred)

#verificar mejor los resultados
confusion_matrix(y_text,y_pred)