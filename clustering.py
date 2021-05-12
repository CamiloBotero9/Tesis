import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from sklearn.cluster import KMeans


vinos=pd.read_csv('C:/Users/Camilo/Desktop/Universidad/Tesis 2/vinos.csv', sep=',')

etiqueta=vinos['Clasificacion']
vinos.drop('Clasificacion',axis=1,inplace=True)
vinos.drop('Unnamed: 0',axis=1,inplace=True)

#normalizacion de datos
vinos_norm=(vinos-vinos.min())/(vinos.max()-vinos.min())

#Creacion del arco 
codo=[]

for i in range(1,11):
     kmeans=KMeans(n_clusters=i,max_iter=300)
     kmeans.fit(vinos_norm)
     codo.append(kmeans.inertia_)

plt.plot(range(1,11),codo)
plt.title('Arco')
plt.xlabel('clusters')
plt.ylabel('codo')
plt.show()

#Aplicacion del clustering
cluster=KMeans(n_clusters=2,max_iter=300) 
cluster.fit(vinos_norm)

#agregar kmeans a la tabla 
vinos['Kmeans_cluster']=cluster.labels_


#Visualizacion

from sklearn.decomposition import PCA

pca= PCA(n_components=2)
pca_vinos=pca.fit_transform(vinos_norm)
pca_vinos_df=pd.DataFrame(data=pca_vinos,columns=['componente1','componente2'])
pca_nombres_vinos=pd.concat([pca_vinos_df,vinos[['Kmeans_cluster']]],axis=1)

#Imagen de la fisugra obtenida

fig=plt.figure(figsize=(6,6))
ax=fig.add_subplot(1,1,1)
ax.set_xlabel('componente1',fontsize=15)
ax.set_ylabel('componente2',fontsize=15)
ax.set_title('componentes principales',fontsize=15)

colores=np.array(['blue','red'])
ax.scatter(x=pca_nombres_vinos.componente1, y=pca_nombres_vinos.componente2,c=colores[pca_nombres_vinos.Kmeans_cluster],s=50)

plt.show()


#####Arbol de desicion para comprovar las predicciones 

from sklearn.tree import DecisionTreeClassifier
from sklearn.model_selection import train_test_split
from sklearn.metrics import confusion_matrix
from sklearn import metrics

#Variables de entrenamiento 

x=vinos_norm[['fixed acidity', 'volatile acidity', 'citric acid', 'residual sugar',
       'chlorides', 'free sulfur dioxide', 'total sulfur dioxide', 'density',
       'pH', 'sulphates', 'alcohol', 'quality']]

y=vinos['Kmeans_cluster']

#Funcion de entrenamiendo con las variables anteriores

x_train,x_text,y_train,y_text=train_test_split(x,y,random_state=3)

#asignacion del arbol
dtc=DecisionTreeClassifier()

#entrenamiento de variables
dtc.fit(x_train,y_train)

#prediccion de variables
y_pred=dtc.predict(x_text)

#ver exacitud de los resultados
exactitud=metrics.accuracy_score(y_text,y_pred)

#verificar mejor los resultados
confusion_matrix(y_text,y_pred)