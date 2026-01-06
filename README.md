ler## Informasi Pribadi

| **Atribut**      | **Detail**               |
|------------------|--------------------------|
| **Nama**         | Endang Sirait   |
| **NIM**          | 312310588               |
| **Kelas**        | TI.23.A5                 |
| **Mata Kuliah**  | Pemrograman Visual       |

## Deskripsi

Halo! Saya Endang Sirait, mahasiswa di program studi Teknik Informatika, kelas TI.23.A5. Saya sedang mengikuti mata kuliah **Pemrograman Visual**, yang berfokus pada pengembangan aplikasi menggunakan prinsip-prinsip desain visual untuk menciptakan antarmuka pengguna yang menarik dan fungsional.

Sebagai bagian dari mata kuliah ini, saya mengembangkan beberapa proyek yang memanfaatkan konsep-konsep desain antarmuka visual, serta pengembangan aplikasi berbasis grafis dan multimedia.


- **Backend (ASP.NET)**:
   - Pastikan kamu sudah menginstall **.NET SDK** dan **Runtime** pada mesin kamu.
   - Gunakan perintah berikut untuk meng## Tujuan dan Fokus Proyek

Dalam mata kuliah **Pemrograman Visual**, saya fokus pada:
- **Desain Antarmuka Pengguna (UI)**: Mempelajari bagaimana merancang antarmuka yang intuitif dan user-friendly.
- **Pemrograman Aplikasi Grafis**: Menggunakan berbagai framework dan alat untuk membuat aplikasi dengan elemen grafis interaktif.
- **Pengembangan Multimedia**: Menyusun elemen-elemen visual dan multimedia yang menyatu dalam aplikasi untuk meningkatkan pengalaman pengguna.

## Keterampilan

| **Keahlian**           | **Detail**                      |
|------------------------|---------------------------------|
| **Bahasa Pemrograman** | Python, JavaScript, HTML, CSS   |
| **Framework**          | React, Bootstrap, Tkinter       |
| **Alat Desain**        | balsamic                        |
| **Database**           | MongoDB, MySQL                  |

## Kontak

Jika kamu ingin berdiskusi atau memiliki pertanyaan terkait proyek atau mata kuliah ini, jangan ragu untuk menghubungi saya melalui:
- **Email**: [endaangsirait2005@gmail.com]

## Tujuan dan Fokus Proyek

Dalam mata kuliah **Pemrograman Visual**, saya fokus pada:
- **Desain Antarmuka Pengguna (UI)**: Mempelajari bagaimana merancang antarmuka yang intuitif dan user-friendly.
- **Pemrograman Aplikasi Grafis**: Menggunakan berbagai framework dan alat untuk membuat aplikasi dengan elemen grafis interaktif.
- **Pengembangan Multimedia**: Menyusun elemen-elemen visual dan multimedia yang menyatu dalam aplikasi untuk meningkatkan pengalaman pengguna.

## 1. Setting Web Service dan Configuration Web

Untuk memulai penggunaan Dealer Motor, pastikan kamu telah melakukan konfigurasi web service dan pengaturan aplikasi dengan benar. Berikut adalah langkah-langkah konfigurasi yang perlu dilakukan:

### 1.1 **Install Dependencies (Untuk Backend dan Frontend)**

- **Backend (ASP.NET)**:
   - Pastikan kamu sudah menginstall **.NET SDK** dan **Runtime** pada mesin kamu.
   - Gunakan perintah berikut untuk menginstall dependensi di sisi backend:
     ```bash
     dotnet restore
     ```
   - Untuk menjalankan server backend, gunakan perintah berikut:
     ```bash
     dotnet run
     ```
   - Pastikan bahwa server ASP.NET berjalan pada `http://localhost:5258` (atau sesuai dengan pengaturan port yang telah dikonfigurasi).

- **Frontend (Bootstrap)**:
   - Proyek ini menggunakan **Bootstrap** untuk desain responsif dan antarmuka pengguna yang ramah.
   - Untuk menjalankan frontend secara lokal, cukup buka file `index.html` di browser atau gunakan server lokal jika ingin lebih interaktif.
   - Untuk menginstall dependensi frontend jika diperlukan:
     ```bash
     npm install
     ```

### 1.2 **Konfigurasi Database dengan MongoDB Compass**

- **Instalasi MongoDB Compass**:
   - Pastikan **MongoDB Compass** sudah terpasang di mesin kamu untuk memanage database.
   - Jika belum, kamu bisa mengunduhnya [di sini](https://www.mongodb.com/products/compass).

- **Pengaturan Database**:
   - Buka file konfigurasi di `config/database.js` dan pastikan untuk mengonfigurasi URI MongoDB kamu.
   - Contoh konfigurasi:
     ```javascript
     const mongoose = require('mongoose');
     mongoose.connect('mongodb://localhost:27017/marshlaundrydb', { useNewUrlParser: true, useUnifiedTopology: true });
     ```

- **Jalankan MongoDB**:
   - Jika menggunakan MongoDB secara lokal, pastikan server MongoDB kamu berjalan dengan perintah:
     ```bash
     mongod
     ```
   - Jika menggunakan MongoDB Atlas, pastikan kamu mendapatkan connection string dan menggantinya di `database.js`.

### 1.3 **Menjalankan Server**

- Setelah konfigurasi di atas selesai, kamu dapat menjalankan server menggunakan perintah:
   ```bash
   dotnet run


2. Nama Project dan Penjelasan Penggunaannya

Nama Project: MarshLaundryDb

Penjelasan:

Dealer motor Honda merupakan salah satu unit usaha yang bergerak di bidang penjualan kendaraan roda dua serta pelayanan terkait, seperti pengelolaan data konsumen, stok motor, dan transaksi penjualan. Dalam praktiknya, proses pengelolaan data pada dealer sering kali masih dilakukan secara manual atau semi-komputerisasi, sehingga menimbulkan berbagai permasalahan seperti kesalahan pencatatan, keterlambatan pelayanan, serta kesulitan dalam penyusunan laporan penjualan.

Alasan Menggunakan MarshLaundryDb:

Otomatisasi Proses: Mengurangi kesalahan manual dan meningkatkan efisiensi pengelolaan Dealermotor.

Pengalaman Pengguna yang Lebih Baik: Dengan antarmuka yang responsif dan mudah digunakan, pelanggan dapat dengan mudah melakukan pemesanan dan memantau status Pembelian mereka.

Laporan dan Analitik: Memungkinkan pengelola untuk menghasilkan laporan tentang transaksi, status dealermotor, dan kinerja usaha secara real-time.

3. Bisnis Proses

Proses bisnis dalam MarshLaundryDb meliputi beberapa tahapan penting sebagai berikut:

3.1 Pelanggan Membuat Pesanan

Pelanggan melakukan pemesanan motor melalui antarmuka pengguna yang mudah dipahami. Mereka memilih jenis layanan yang diinginkan, mengisi informasi pengiriman, dan memilih metode pembayaran.

3.2 Pengelolaan Pesanan oleh Admin

Admin menerima pesanan yang masuk dan mengupdate status motor (misalnya: pembelian Honda CBR150R, selesai, atau dalam proses Perjalanan ). Sistem secara otomatis mengingatkan admin jika ada pesanan yang perlu diperhatikan.

3.3 Pembayaran dan Penyelesaian Pesanan

Pelanggan dapat melakukan pembayaran menggunakan berbagai metode yang telah disediakan (misalnya: kartu kredit, transfer bank, pembayaran tunai).

Setelah pembayaran dikonfirmasi, status pesanan diubah menjadi "selesai", dan pelanggan diberitahu untuk pengambilan motor mereka.

3.4 Pengambilan motor

Pelanggan mengambil motor mereka setelah status pesanan diperbarui menjadi selesai.

4. Model Data

Model data dalam Dealermotor dirancang untuk menyimpan semua informasi yang diperlukan untuk pengelolaan pesanan dan transaksi. Berikut adalah beberapa model data yang digunakan:

4.1 User Model

Menyimpan data pengguna (pelanggan atau admin) termasuk nama, email, dan jenis akun.

Digunakan untuk mengidentifikasi dan mengelola hak akses pengguna di sistem.

4.2 Order Model

Menyimpan informasi terkait setiap pesanan, termasuk jenis layanan, harga, status pesanan, dan ID pengguna yang terkait.

Digunakan untuk melacak status motor dari mulai pemesanan hingga pengambilan.

4.3 Payment Model

Menyimpan informasi terkait pembayaran untuk setiap pesanan, termasuk jumlah yang dibayar, metode pembayaran, dan status pembayaran.

Digunakan untuk memproses pembayaran dan memverifikasi transaksi.

5. Schema Tim dalam Mengelola Project

Proyek Dealermotor dikelola oleh tim yang terdiri dari beberapa role utama yang bekerja bersama untuk memastikan pengembangan proyek berjalan lancar:

5.1 Frontend Developer

Bertanggung jawab untuk pengembangan antarmuka pengguna menggunakan Bootstrap. Mereka memastikan desain aplikasi responsif dan menarik di berbagai perangkat.

5.2 Backend Developer

Bertanggung jawab untuk pengembangan API menggunakan ASP.NET, memastikan server backend dapat menangani permintaan dengan efisien dan aman.

5.3 Database Administrator

Mengelola MongoDB Compass untuk memastikan data tersimpan dengan baik dan aman. Mereka bertanggung jawab untuk merancang skema database dan melakukan pemeliharaan data.

5.4 Project Manager

Mengelola keseluruhan proyek, timeline, dan koordinasi antar tim. Mereka memastikan proyek tetap pada jalur yang benar dan memenuhi tujuan yang diinginkan.

6. MOCK UP

# Home
<img width="1341" height="575" alt="Home" src="https://github.com/user-attachments/assets/931a72cd-eb85-48c3-aac1-1f4732c7945d" />

" />

# home Register
<img width="1362" height="600" alt="Halaman Register" src="https://github.com/user-attachments/assets/b5d5419a-173b-4264-9279-22a5c1c401e8" />


# home Masuk
<img width="1359" height="599" alt="Halaman Masuk" src="https://github.com/user-attachments/assets/6b6d282c-2775-4a9f-a91c-8a708c9a494b" />




**HALAMAN USER**

# beranda user
<img width="1346" height="592" alt="Beranda User" src="https://github.com/user-attachments/assets/505f39a0-2c3d-4546-b01a-f86fb851b558" />


# halaman layanan Dealermotor
<img width="1351" height="608" alt="Halaman Layanan dealermotor" src="https://github.com/user-attachments/assets/0fc16a32-da30-44be-8025-a10b698061e2" />


# halaman keranjang
<img width="1364" height="600" alt="Halaman Keranjang" src="https://github.com/user-attachments/assets/ee3bb883-934d-485c-8be9-fe63a1556c84" />


# halaman pesanan user
<img width="1359" height="597" alt="Pesanan User" src="https://github.com/user-attachments/assets/505b7eaa-7c88-4274-bba3-c312fa97f529" />


# halaman profile  
<img width="1355" height="597" alt="Profil" src="https://github.com/user-attachments/assets/dd85601b-0531-41ce-9823-921152b1bdf5" />





**HALAMAN ADMIN**

# halaman dashbord
<img width="1363" height="596" alt="Halaman Dashbord" src="https://github.com/user-attachments/assets/1f13a4b7-0133-4259-b72c-c2bfd6ab27da" />

# halaman Produk
<img width="1341" height="592" alt="Halaman Produk" src="https://github.com/user-attachments/assets/9346e7a5-85ce-41d6-9073-9762aee04fc1" />



# halaman pesanan
<img width="1365" height="610" alt="Halaman Pesanan" src="https://github.com/user-attachments/assets/8437a826-8c33-43aa-a96b-6ba14c51dce0" />


# halaman kelola user
<img width="1360" height="596" alt="Halaman Kelola User" src="https://github.com/user-attachments/assets/af4ca453-9f9e-4087-a7ff-c5949a1eaf0d" />

# halaman Transaksi Penjualan
<img width="1366" height="720" alt="Screenshot 2026-01-06 201722" src="https://github.com/user-attachments/assets/29d5ddc6-d9a3-4a6f-9746-896f0bf64882" />

