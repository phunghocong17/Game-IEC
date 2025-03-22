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

![image](https://github.com/user-attachments/assets/2c05a566-f278-4e33-9ab2-895ecb3394bc)


- Xuất hiện bug khi hết thời gian chơi cùng lúc xuất hiện hint animation và sau khi chơi lại timer không đếm nữa

![image](https://github.com/user-attachments/assets/60b1a266-a0ba-4085-a02b-4d304efb96e1)




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


Kết quả có được : 

![image](https://github.com/user-attachments/assets/f2fb25a8-7d9e-444f-9399-18360a491512)


# Tạo nút restart button 

đầu tiên tạo nút restart để người chơi có thể click vào :

![image](https://github.com/user-attachments/assets/8e352522-a4ba-4ae0-9942-1ad362544e58)

Khai báo button restart và  viết hàm restart:

 ![image](https://github.com/user-attachments/assets/1bcff03d-896b-4a73-b8d9-97375b1b027e)

 ở hàm Loadlevel thêm code để ngăn chặn việc add compponent liên tục :

![image](https://github.com/user-attachments/assets/94759675-b7de-4412-a0ad-cb34dc705d18)


# Edit the FillGapsWithNewItems function

![image](https://github.com/user-attachments/assets/88fac1a9-9036-47fe-a32f-73d7a92fd08a)

  if (x > 0 && m_cells[x - 1, y].Item is NormalItem leftItem) excludedTypes.Add(leftItem.ItemType);
  if (x < boardSizeX - 1 && m_cells[x + 1, y].Item is NormalItem rightItem) excludedTypes.Add(rightItem.ItemType);
  if (y > 0 && m_cells[x, y - 1].Item is NormalItem bottomItem) excludedTypes.Add(bottomItem.ItemType);
  if (y < boardSizeY - 1 && m_cells[x, y + 1].Item is NormalItem topItem) excludedTypes.Add(topItem.ItemType);

ở đây em lọc và lấy các loại item trong 4 ô xung quanh để add vào excludedTypes rồi chọn item có số lượng ít nhất và ko nằm trong excludedTypes

var newItemType = itemCounts
                .Where(kvp => !excludedTypes.Contains(kvp.Key))
                .OrderBy(kvp => kvp.Value)
                .Select(kvp => kvp.Key)
                .FirstOrDefault();

và gán nó vào vị trí mới 

# Về việc ưu điểm và nhược điểm của thiết kế dự án

Ưu điểm :

- coregamelay khá ổn , có nhiều chỗ cần tối ưu hơn về code nhưng xét chung thì khá ổn để cho game phát triển lâu dài
- Hệ thống UI có tổ chức tốt
- Sử dụng dotween để có thể làm được nhưng animation mượt trong game 

Nhược điểm :
- Code cần tối ưu vài chỗ nhất là dùng objectpooling thay vì Instantiate để tăng hiệu suất game 
- Chưa tối ưu ảnh để cho build size
- Sử dụng singleton thay vì dùng findobjectbytypes hoặc add component sẽ làm game mượt hơn và có thể để cho người sau dễ bảo trì code hơn 
- Game còn 1 số bug và có thể tổ chức việc quản lí prefab cho dễ sử dụng hơn 
