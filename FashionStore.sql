CREATE OR REPLACE DATABASE FashionStore;
USE FashionStore;
-- DROP DATABASE FashionStore;

CREATE OR REPLACE TABLE Admin (
    username VARCHAR(50) PRIMARY KEY,
    passwordd VARCHAR(20) NOT NULL
);

INSERT INTO Admin (username, passwordd) VALUES
('admin1', 'password11'),
('admin2', 'password22'),
('manager1', 'managerpass23'),
('staff1', 'staffpass12'),
('owner', 'ownerpass34'),
('support1', 'supportpass44');


CREATE OR REPLACE TABLE Supplier (
    id_supplier CHAR(10) PRIMARY KEY,
    nama_supplier VARCHAR(100) NOT NULL,
    nomor_telephone_supplier VARCHAR(15) NOT NULL
);

INSERT INTO Supplier (id_supplier, nama_supplier, nomor_telephone_supplier) VALUES
('A001', 'Supplier A', '081234567890'),
('A002', 'Supplier B', '081345678901'),
('A003', 'Supplier C', '081456789012'),
('A004', 'Supplier D', '081567890123'),
('A005', 'Supplier E', '081678901234'),
('A006', 'Supplier F', '081789012345');


CREATE OR REPLACE TABLE Category (
    kode_category CHAR(10) PRIMARY KEY,
    nama_category VARCHAR(50) NOT NULL
);

INSERT INTO Category (kode_category, nama_category) VALUES
('C001', 'FormalWear'),
('C002', 'CasualWear'),
('C003', 'Sportswear'),
('C004', 'TraditWear'),
('C005', 'PartyWear'),
('C006', 'Outerwears');


CREATE OR REPLACE TABLE Pembelian (
    id_pembelian CHAR(10) PRIMARY KEY,
    id_supplier CHAR(10) NOT NULL,
    kode_category CHAR(10) NOT NULL,
    nama_baju VARCHAR(100) NOT NULL,
    ukuran VARCHAR(10),
    jumlah INT NOT NULL,
    harga INT NOT NULL,
    total_harga INT NOT NULL,
    tanggal_pembelian DATE,
    gambar LONGBLOB,
    FOREIGN KEY (id_supplier) REFERENCES Supplier(id_supplier) ON DELETE CASCADE,
    FOREIGN KEY (kode_category) REFERENCES Category(kode_category) ON DELETE CASCADE
);

INSERT INTO Pembelian (id_pembelian, id_supplier, kode_category, nama_baju, ukuran, jumlah, harga, total_harga, tanggal_pembelian, gambar) VALUES
('E001', 'A001', 'C001', 'Blazer', 'M', 10, 150000, 1500000, '2024-11-20', LOAD_FILE('C:/Users/DELL 7390/Pictures/Kemeja17.jpeg')),
('E002', 'A002', 'C002', 'T-shirt', 'L', 20, 50000, 1000000, '2024-11-21', LOAD_FILE('C:/Users/DELL 7390/Pictures/Kemeja6.jpeg')),
('E003', 'A003', 'C003', 'Track Pants', 'XL', 15, 80000, 1200000, '2024-11-22', LOAD_FILE('C:/Users/DELL 7390/Pictures/Kemeja7.jpeg')),
('E004', 'A004', 'C004', 'Kurta', 'L', 12, 120000, 1440000, '2024-11-23', LOAD_FILE('C:/Users/DELL 7390/Pictures/Kemeja8.jpeg')),
('E005', 'A005', 'C005', 'Evening Gown', 'S', 5, 200000, 1000000, '2024-11-24', LOAD_FILE('C:/Users/DELL 7390/Pictures/Kemeja10.jpeg')),
('E006', 'A006', 'C006', 'Jacket', 'M', 8, 180000, 1440000, '2024-11-25', LOAD_FILE('C:/Users/DELL 7390/Pictures/Kemeja11.jpeg'));



CREATE OR REPLACE TABLE Product (
    id_produk INT AUTO_INCREMENT PRIMARY KEY,
    id_pembelian CHAR(10) NOT NULL,
    kode_category CHAR(10) NOT NULL,
    nama_baju VARCHAR(100) NOT NULL,
    ukuran VARCHAR(10),
    harga INT NOT NULL,
    stok INT NOT NULL,
    tanggal_pembelian DATE,
    gambar LONGBLOB,
    FOREIGN KEY (id_pembelian) REFERENCES Pembelian (id_pembelian) ON DELETE CASCADE,
    FOREIGN KEY (kode_category) REFERENCES Category (kode_category) ON DELETE CASCADE
);


CREATE OR REPLACE TABLE Customer (
    id_customer CHAR(10) PRIMARY KEY,
    nama_costumer VARCHAR(100) NOT NULL,
    nomor_telephone_custumer VARCHAR(15) NOT NULL
);

INSERT INTO Customer (id_customer, nama_costumer, nomor_telephone_custumer) VALUES
('B001', 'John Doe', '082123456789'),
('B002', 'Jane Smith', '082234567890'),
('B003', 'Michael Brown', '082345678901'),
('B004', 'Emily Davis', '082456789012'),
('B005', 'Chris Johnson', '082567890123'),
('B006', 'Relita', '082678901234');


CREATE TABLE Penjualan (
    id_penjualan CHAR(10) PRIMARY KEY,
    id_customer CHAR(10) NOT NULL,
    id_produk INT NOT NULL,
    nama_baju VARCHAR(100) NOT NULL,
    ukuran VARCHAR(10),
    jumlah INT NOT NULL,
    harga INT NOT NULL,
    total_harga INT NOT NULL,
    tanggal_penjualan DATE,
    gambar LONGBLOB,
    FOREIGN KEY (id_customer) REFERENCES Customer(id_customer) ON DELETE CASCADE,
    FOREIGN KEY (id_produk) REFERENCES Product (id_produk) ON DELETE CASCADE
);


DELIMITER $$

CREATE OR REPLACE TRIGGER AfterInsertPembelian
AFTER INSERT ON Pembelian
FOR EACH ROW
BEGIN
    DECLARE existing_product_id INT;

    -- Cek apakah produk dengan kriteria yang sama sudah ada
    SELECT id_produk INTO existing_product_id
    FROM Product 
    WHERE kode_category = NEW.kode_category 
      AND nama_baju = NEW.nama_baju 
      AND ukuran = NEW.ukuran
    LIMIT 1;

    IF existing_product_id IS NOT NULL THEN
        -- Update stok jika produk sudah ada
        UPDATE Product 
        SET stok = stok + NEW.jumlah,
            harga = NEW.harga, -- Opsional: update harga jika diperlukan
            tanggal_pembelian = NEW.tanggal_pembelian -- Update tanggal pembelian terakhir
        WHERE id_produk = existing_product_id;
    ELSE
        -- Insert produk baru jika belum ada
        INSERT INTO Product (
            id_pembelian, 
            kode_category, 
            nama_baju, 
            ukuran, 
            harga, 
            stok, 
            tanggal_pembelian, 
            gambar
        ) VALUES (
            NEW.id_pembelian,
            NEW.kode_category,
            NEW.nama_baju,
            NEW.ukuran,
            NEW.harga,
            NEW.jumlah, 
            NEW.tanggal_pembelian,
            NEW.gambar
        );
    END IF;
END$$

DELIMITER ;





DELIMITER $$

CREATE OR REPLACE TRIGGER AfterInsertPenjualan
BEFORE INSERT ON Penjualan
FOR EACH ROW
BEGIN
    DECLARE product_stock INT;
    DECLARE product_price INT;
    DECLARE product_image LONGBLOB;
    DECLARE product_name VARCHAR(100);
    DECLARE product_size VARCHAR(10);

    -- Ambil data dari tabel Product berdasarkan id_produk
    SELECT stok, harga, gambar, nama_baju, ukuran
    INTO product_stock, product_price, product_image, product_name, product_size
    FROM Product
    WHERE id_produk = NEW.id_produk;

    -- Periksa apakah stok cukup
    IF product_stock >= NEW.jumlah THEN
        -- Kurangi stok di tabel Product
        UPDATE Product
        SET stok = stok - NEW.jumlah
        WHERE id_produk = NEW.id_produk;

        -- Isi kolom Penjualan dengan data dari Product
        SET NEW.nama_baju = product_name;
        SET NEW.ukuran = product_size;
        SET NEW.harga = product_price;
        SET NEW.total_harga = NEW.jumlah * product_price;
        SET NEW.gambar = product_image;
    ELSE
        -- Jika stok tidak mencukupi, keluarkan error
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Stok produk tidak mencukupi untuk jumlah yang dipesan';
    END IF;
END$$

DELIMITER ;

INSERT INTO Penjualan (id_penjualan, id_customer, id_produk, jumlah, tanggal_penjualan) VALUES
('F001', 'B001', 1, 2, '2024-11-26'),
('F002', 'B002', 2, 3, '2024-11-27'),
('F003', 'B003', 3, 1, '2024-11-28'),
('F004', 'B004', 4, 2, '2024-11-29'),
('F005', 'B005', 5, 4, '2024-11-30'),
('F006', 'B006', 6, 1, '2024-12-01');
