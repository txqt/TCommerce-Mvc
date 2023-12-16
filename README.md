
## Hướng dẫn cài đặt
1. Clone dự án từ GitHub:

    ```bash
    git clone https://github.com/thanhhvxqt/TCommerce-Mvc.git
    ```

2. Mở solution trong VS2019 hoặc VS2022.
3. Chạy lệnh sau để cài đặt các gói NuGet:

    ```bash
    dotnet restore
    ```
4. Build dự án (Ctrl + Shift + B) và config VS2019 hoặc VS2022 chạy 2 project T.Web và T.WebApi (hoặc bạn có thể làm cách nào đó khác để chạy 2 project này. Bắt buộc phải chạy 2 project này trong lần đầu).
5. Run dự án với phím F5 hoặc Ctrl + F5
6. Điền thông tin
![Tài khoản admin và tạo dữ liệu mẫu](setup-images/store-info.png)
![Điền thông tin của datatable(MSSQL)](setup-images/db-info.png)
