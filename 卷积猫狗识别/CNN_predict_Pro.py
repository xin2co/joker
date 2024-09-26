import tkinter as tk
from PIL import Image, ImageTk
import numpy as np
from keras.models import load_model
import os
import random

# 模型地址
model_path = 'D:\\py_project\\Machinelearning\\catdog\\basic_cnn_result.h5'
# 载入模型
model = load_model(model_path)

# 定义函数读取测试文件夹中的照片
def read_random_image():
    folder = r'D:\\py_project\\Machinelearning\\catdog\\ma1ogo3ushu4ju4ji2\\dogs_cats\\data\\test2\\'
    file_path = folder + random.choice(os.listdir(folder))
    print(file_path)
    pil_im = Image.open(file_path, 'r')
    return pil_im

# 对一个使用模型对读取出的图片进行预测

def get_predict(pil_im, model):
    # 对图片进行缩放
    pil_im = pil_im.resize((200, 200))
    # 将格式转换为 numpy array 格式
    array_im = np.asarray(pil_im)
    array_im = np.expand_dims(array_im, axis=0)
    # 对图片进行预测
    result = model.predict(array_im)
    if result[0][0] > 0.5:
        return "预测结果是：狗"
    else:
        return "预测结果是：猫"

# 更新图像和标签的函数
def update_image_label():
    pil_im = read_random_image()
    prediction = get_predict(pil_im, model)
    photo = ImageTk.PhotoImage(pil_im.resize((200, 200)))
    image_label.config(image=photo)
    image_label.image = photo  # 保持对图片的引用
    predict_label.config(text=prediction)

# 创建主窗口
root = tk.Tk()
root.title("猫狗识别器")

# 创建一个Label用于显示图片
image_label = tk.Label(root)
image_label.pack()

# 创建一个Label用于显示预测结果
predict_label = tk.Label(root, text="")
predict_label.pack()

# 创建一个按钮，用于更新图片和预测结果
update_button = tk.Button(root, text="重新抽取照片识别", command=update_image_label)
update_button.pack()

# 更新图像和标签
update_image_label()

# 运行主循环
root.mainloop()
