// MEMBUAT VARIABEL YANG ISINYA QUERY SQL UNTUK INSERT DATA
string query = "INSERT INTO NAMA_TABEL VALUES("VALUES1, VALUES2");";

// MEMBUAT PERINTAH SQL
SqlCommand cmd = new SqlCommand(query, KONEKSI_DATABASE);

// MEMBUKA KONEKSI DATABASE
KONEKSI_DATABASE.Open();

// MENGEKSEKUSI QUERY SQL
cmd.ExecuteNonQuery();

// MENUTUP KONEKSI DATABASE
KONEKSI_DATABASE.Close();

// MENAMPILKAN PESAN "data telah ditambahkan."
MessageBox.Show("data telah ditambahkan.");
