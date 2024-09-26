import tkinter as tk
from tkinter import filedialog
from PIL import Image, ImageTk
from keras.models import load_model
import os
import numpy as np
import random

# 模型地址
model_path = 'D:\\py_project\\Machinelearning\\catdog\\basic_cnn_result.h5'
# 载入模型
model = load_model(model_path)

# 定义函数读取测试文件夹中的照片
def read_random_image(folder):
    file_path = os.path.join(folder, random.choice(os.listdir(folder)))
    pil_im = Image.open(file_path)
    return pil_im

# 对一个使用模型对读取出的图片进行预测
def get_predict(pil_im, model):
    pil_im = pil_im.resize((200, 200))
    array_im = np.expand_dims(pil_im, axis=0)
    array_im = array_im / 255.0
    result = model.predict(array_im)
    dog_prob = result[0][0]
    cat_prob = 1 - dog_prob
    if dog_prob > cat_prob:
        return "预测结果是：狗，概率约为：{:.2f}".format(dog_prob)
    else:
        return "预测结果是：猫，概率约为：{:.2f}".format(cat_prob)

# 更新图片和预测结果
def update_image_and_prediction():
    global pil_im, photo, prediction_label
    # 读取随机图片
    pil_im = read_random_image(test_folder)
    # 更新图片
    photo = ImageTk.PhotoImage(pil_im)
    image_label.config(image=photo)
    image_label.image = photo
    # 获取预测结果
    prediction = get_predict(pil_im, model)
    # 更新预测结果
    prediction_label.config(text=prediction)

# 测试图片文件夹路径
test_folder = r'D:\\py_project\\Machinelearning\\catdog\\ma1ogo3ushu4ju4ji2\\dogs_cats\\data\\test2\\'

# 创建主窗口
root = tk.Tk()
root.title("猫狗识别器")

# 创建图片标签
image_label = tk.Label(root)
image_label.pack(side=tk.LEFT, padx=10, pady=10)

# 创建预测结果标签
prediction_label = tk.Label(root, text="", font=("Helvetica", 16))
prediction_label.pack(side=tk.RIGHT, padx=10, pady=10)

# 创建更新按钮
update_button = tk.Button(root, text="更新图片和预测", command=update_image_and_prediction)
update_button.pack(side=tk.BOTTOM, pady=10)

# 初始化图片和预测结果
pil_im = read_random_image(test_folder)
photo = ImageTk.PhotoImage(pil_im)
image_label.config(image=photo)
image_label.image = photo
prediction = get_predict(pil_im, model)
prediction_label.config(text=prediction)

# 运行主循环
root.mainloop()
