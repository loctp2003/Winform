Create table HocSinh(
	MaHS varchar(100),
	Ten varchar(100),
	QueQuan varchar(100),
	NgaySinh Date,
	CMND varchar(100),
	Email varchar(100),
	SDT varchar(100)
)
Create table GiaoVien(
	MaGV varchar(100),
	Ten varchar(100),
	QueQuan varchar(100),
	NgaySinh Date,
	CMND varchar(100),
	Email varchar(100),
	SDT varchar(100)
)
Insert into HocSinh(MaHS, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values('21110535', 'Vu Duc Loc', 'Lam Dong', '2003-1-2', '251301356', 'asdfe123@gmail.com', '0834773944')
Insert into HocSinh(MaHS, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values('21110536', 'Nguyen Van A', 'TPHCM', '2003-1-5', '251301357', 'asdf12323@gmail.com', '0834773945')
Insert into HocSinh(MaHS, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values('21110537', 'Nguyen Van B', 'Binh Duong', '2003-3-2', '251301358', 'asd21as23@gmail.com', '0834773946')
Insert into GiaoVien(MaGV, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values('12345678', 'Nguyen Van X', 'Ha Noi', '1969-3-3', '251301360', 'asd21xxxx@gmail.com', '0123773946')
Insert into GiaoVien(MaGV, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values('12345679', 'Nguyen Van Y', 'Ha Noi', '1970-10-11', '251301361', 'asd21yyyy@gmail.com', '0738773946')
Insert into GiaoVien(MaGV, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values('12345680', 'Nguyen Van Z', 'Ha Noi', '1990-3-12', '251301362', 'asd21zzzz@gmail.com', '0721773946')

select *from HocSinh
select *from GiaoVien