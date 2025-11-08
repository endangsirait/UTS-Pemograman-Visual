# 🔐 Informasi Login Admin Dealermotor

## Kredensial Default Admin

Setelah aplikasi pertama kali dijalankan, sistem akan **otomatis membuat** akun admin default dengan kredensial berikut:

### 📧 Email / Username:
```
admin@dealermotor.com
```
atau
```
admin
```

### 🔑 Password:
```
admin123
```

## ⚠️ PENTING - Keamanan

**SILAKAN UBAH PASSWORD SETELAH LOGIN PERTAMA KALI!**

1. Login menggunakan kredensial di atas
2. Masuk ke menu **Profile**
3. Gunakan fitur **Change Password** untuk mengubah password
4. Pilih password yang kuat dan aman

## 📝 Cara Login

1. Buka aplikasi di browser: `http://localhost:5258` atau `https://localhost:7249`
2. Klik tombol **"Masuk"** atau langsung ke: `/Account/Login`
3. Masukkan:
   - **Email**: `admin@dealermotor.com`
   - **Password**: `admin123`
4. Klik **Login**
5. Anda akan diarahkan ke **Admin Dashboard**

## 🛠️ Fitur Admin

Setelah login sebagai admin, Anda dapat:
- ✅ Mengelola Motor (CRUD)
- ✅ Mengelola Pesanan
- ✅ Mengelola User (termasuk mengubah role user menjadi Admin)
- ✅ Melihat Dashboard dengan statistik

## 🔄 Membuat Admin Baru

Jika ingin membuat admin baru:
1. Login sebagai admin
2. Masuk ke menu **Kelola User**
3. Cari user yang ingin dijadikan admin
4. Klik tombol untuk **Toggle Role** (ubah role menjadi Admin)

## ❓ Troubleshooting

### Admin tidak bisa login?
- Pastikan MongoDB sudah running
- Pastikan aplikasi sudah dijalankan setidaknya sekali (untuk create admin otomatis)
- Cek console output saat aplikasi start, harus ada pesan "✅ Default admin user created!"

### Lupa password admin?
Jika lupa password dan tidak ada admin lain:
1. Hapus database MongoDB: `DealermotorDB`
2. Restart aplikasi (akan create admin baru otomatis)
3. Atau ubah langsung di MongoDB menggunakan MongoDB Compass

---

**Catatan**: Kredensial ini hanya untuk development. Untuk production, **WAJIB** ubah password dan gunakan password yang kuat!

