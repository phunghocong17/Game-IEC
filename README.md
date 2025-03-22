# 3 cách để tối ưu performance của game là 
- Tối ưu các file ảnh cho game , game có nhiều file ảnh chưa được tối ưu nên có thể sẽ làm bản buize có size lớn
  cách tối ưu ví dụ như ảnh dưới đây : 
  
![image](https://github.com/user-attachments/assets/e7f307b7-e89f-41a3-83c1-577e53cd4da1)

- Sử dụng hàm hợp lý, có thể gắn UIMainManager hoặc sử dụng Singleton cho class UIMainManager thay vì sử dụng hàm FindObjectOfType làm giảm hiệu suất game và sẽ thành khó khăn trong việc duy trì và phát triển code cngx như game .

- ![image](https://github.com/user-attachments/assets/c6ba37ed-8c99-4611-93bf-8616f10794eb)
  
- Ở trong 1 scene có quá nhiều gameobject làm giảm hiệu suất game và có thể gây giật lag, tụt fps làm trải nghiệm người dùng không tốt 
![image](https://github.com/user-attachments/assets/33495b9c-31c3-4a51-9a2f-6cdbc4138234)

Ở trường hợp này thay vì dùng Instantiate thì ta có thể dùng object pooling để tối ưu game 

![image](https://github.com/user-attachments/assets/b0f7b3c6-b121-4227-a102-6df7f09f8ec1)


# Sử dụng Scriptable object để reskin 

- Đầu tiên tạo script SKinItem kế thừa từ ScriptableObject
![image](https://github.com/user-attachments/assets/c032d404-5bb7-48ff-b027-8704d62e364b)

- Sau đó tạo lớp ItemBoard để sử dụng dữ liệu từ SKinItem

![image](https://github.com/user-attachments/assets/07cc1627-ad01-4192-a10e-e3feeb6660c9)

- Tạo các ScriptableObject tương ứng với 7 item 
![image](https://github.com/user-attachments/assets/e3649012-9613-46f9-9937-4c4dfb9047ab)

Mỗi item tương ứng có thông tin để thay đổi skin 

![image](https://github.com/user-attachments/assets/ecebfc0a-2350-4c73-b890-aa521bc4e1eb)

Gán scriptable tương ứng cho các item 

![image](https://github.com/user-attachments/assets/34399487-6da2-487d-8598-749732a8ac1d)


Kết quả có được 

![Uploading image.png…]()




