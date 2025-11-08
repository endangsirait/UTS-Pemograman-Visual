# Instalasi Dealermotor

## Persyaratan Sistem

1. **.NET 9.0 SDK** - Download dari: https://dotnet.microsoft.com/download/dotnet/9.0
2. **MongoDB** - Download dari: https://www.mongodb.com/try/download/community
3. **Visual Studio 2022** (opsional) atau **Visual Studio Code**

## Langkah Instalasi

### 1. Install .NET 9.0 SDK

1. Download .NET 9.0 SDK dari website resmi Microsoft
2. Install sesuai dengan sistem operasi Anda (Windows)
3. Setelah install, buka Command Prompt baru dan cek dengan:
   ```
   dotnet --version
   ```
   Harus menampilkan versi 9.0.x

### 2. Install MongoDB

1. Download MongoDB Community Server
2. Install MongoDB
3. Pastikan MongoDB service berjalan (biasanya otomatis)
4. MongoDB akan berjalan di `mongodb://localhost:27017` (default)

### 3. Setup Project

1. Buka Command Prompt atau PowerShell
2. Navigate ke folder project:
   ```
   cd C:\dealermobil
   ```

3. Restore dependencies:
   ```
   dotnet restore
   ```

4. Build project:
   ```
   dotnet build
   ```

5. Run project:
   ```
   dotnet run
   ```

   Atau untuk development dengan hot reload:
   ```
   dotnet watch run
   ```

### 4. Akses Aplikasi

Setelah berhasil run, aplikasi akan tersedia di:
- HTTP: http://localhost:5258
- HTTPS: https://localhost:7249

## Troubleshooting

### Error: 'dotnet' is not recognized

**Solusi:**
1. Pastikan .NET SDK sudah terinstall
2. Restart Command Prompt/PowerShell setelah install
3. Cek PATH environment variable:
   - Buka System Properties > Environment Variables
   - Pastikan path ke .NET SDK ada di System PATH
   - Biasanya: `C:\Program Files\dotnet\`

### Error: MongoDB Connection Failed

**Solusi:**
1. Pastikan MongoDB service berjalan
2. Cek di Services (services.msc) apakah MongoDB service running
3. Atau jalankan manual:
   ```
   mongod
   ```

### Error: Port Already in Use

**Solusi:**
1. Ganti port di `Properties/launchSettings.json`
2. Atau stop aplikasi yang menggunakan port tersebut

## Database Configuration

Database name: `DealermotorDB`
Connection string: `mongodb://localhost:27017`

Konfigurasi ada di `appsettings.json`

## Catatan

- Pastikan MongoDB sudah running sebelum menjalankan aplikasi
- Untuk production, ubah connection string di `appsettings.json`
- Default database akan dibuat otomatis saat pertama kali run

