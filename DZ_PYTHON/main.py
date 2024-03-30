# Промежуточная аттестация
#В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего из 1 столбца. 
# Ваша задача перевести его в one hot вид. 
# Сможете ли вы это сделать без get_dummies?

import pandas as pd 
import numpy as np 
import random
 
spisok = ['avto'] * 7
spisok += ['hend'] * 7
random.shuffle(spisok)
num = pd.DataFrame({'AWTOW': spisok})
print(num)
 
print('')

num['tmp'] = 1
num.set_index([num.index, 'AWTOW'], inplace=True)
num = num.unstack(level=-1, fill_value = 0).astype(int)
num.columns = num.columns.droplevel()
num.columns.name = 'data'
print(num)