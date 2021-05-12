import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
import seaborn as sb
from sklearn.cluster import KMeans
from sklearn.metrics import pairwise_distances_argmin_min
from mpl_toolkits.mplot3d import Axes3D



plt.rcParams['figure.figsize'] = (16, 9)
plt.style.use('ggplot')


dataframe =pd.read_csv('C:/Users/Camilo/Desktop/Universidad/Tesis 2/vinos.csv', sep=',')


#dataframe.drop('Unnamed: 0',axis=1,inplace=True)

dataframe.describe()


dataframe.drop(['Clasificacion'],1).hist()
plt.show()

#dataframe=(dataframe-dataframe.min())/(dataframe.max()-dataframe.min())

sb.pairplot(dataframe.dropna(), hue='Clasificacion',height=4,vars=["density","pH","sulphates"],kind='scatter')


X = np.array(dataframe[["density","pH","sulphates"]])
y = np.array(dataframe['Clasificacion'])


fig = plt.figure()
ax = Axes3D(fig)
colores=['blue','red']
asignar=[]
for row in y:
    asignar.append(colores[row])
ax.scatter(X[:, 0], X[:, 1], X[:, 2], c=asignar,s=60)

Nc = range(1,2)
kmeans = [KMeans(n_clusters=i) for i in Nc]

score = [kmeans[i].fit(X).score(X) for i in range(len(kmeans))]

plt.plot(Nc,score)
plt.xlabel('Number of Clusters')
plt.ylabel('Score')
plt.title('Elbow Curve')
plt.show()


kmeans = KMeans(n_clusters=2).fit(X)
centroids = kmeans.cluster_centers_


labels = kmeans.predict(X)

C = kmeans.cluster_centers_
colores=['red','blue']
asignar=[]
for row in labels:
    asignar.append(colores[row])
 
fig = plt.figure()
ax = Axes3D(fig)
ax.scatter(X[:, 0], X[:, 1], X[:, 2], c=asignar,s=60)
ax.scatter(C[:, 0], C[:, 1], C[:, 2], marker='*', c=colores, s=1000)



f1 = dataframe['density'].values
f2 = dataframe['pH'].values
 
plt.scatter(f1, f2, c=asignar, s=70)
plt.scatter(C[:, 0], C[:, 1], marker='*', c=colores, s=1000)
plt.show()



f1 = dataframe['density'].values
f2 = dataframe['sulphates'].values
 
plt.scatter(f1, f2, c=asignar, s=70)
plt.scatter(C[:, 0], C[:, 2], marker='*', c=colores, s=1000)
plt.show()



f1 = dataframe['pH'].values
f2 = dataframe['sulphates'].values
 
plt.scatter(f1, f2, c=asignar, s=70)
plt.scatter(C[:, 1], C[:, 2], marker='*', c=colores, s=1000)
plt.show()


copy =  pd.DataFrame()
copy['Unnamed: 0']=dataframe['Unnamed: 0'].values
copy['Clasificacion']=dataframe['Clasificacion'].values
copy['label'] = labels;
cantidadGrupo =  pd.DataFrame()
cantidadGrupo['color']=colores
cantidadGrupo['cantidad']=copy.groupby('label').size()
cantidadGrupo

group_referrer_index = copy['label'] ==0
group_referrals = copy[group_referrer_index]
 
diversidadGrupo =  pd.DataFrame()
diversidadGrupo['Clasificacion']=[0,1]
diversidadGrupo['cantidad']=group_referrals.groupby('Clasificacion').size()
diversidadGrupo

closest, _ = pairwise_distances_argmin_min(kmeans.cluster_centers_, X)

users=dataframe['Unnamed: 0'].values
for row in closest:
    print(users[row])