use [AdoTest]
create table Roles(
RoleId INT IDENTITY(1,1) PRIMARY KEY,
RoleName varchar(50) not null
);
create table Status(
StatusId INT IDENTITY(1,1) PRIMARY KEY,
StatusName varchar(50) not null
);
create table Methods(
MethodId INT IDENTITY(1,1) PRIMARY KEY,
MethodName varchar(100) not null
);
create table Services(
ServiceId INT IDENTITY(1,1) PRIMARY KEY,
ServiceName varchar(255) not null
);

create table Users(
ID uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
UserID varchar(255) not null,
RoleId int,
MethodId int,
StatusId int,
Foreign key (RoleId) references Roles(RoleId),
Foreign key (MethodId) references Methods(MethodId),
Foreign key (StatusId) references Status(StatusId)
);
insert into Roles (RoleName) values
('Tenant user'),
('Service administrator');
insert into Status (StatusName) values
('Activated'),
('Deactivated');
insert into Methods(MethodName) values
('Microsoft 365 user/group'),
('Google user/group'),
('Salesforce user'),
('Local user');
insert into Services(ServiceName) values
('Document Management System Online (Preveiew)'),
('Insights for Microsoft 365'),
('Fly'),
('Cloud Backup for Saleforce');
insert into Users (UserID,RoleId,MethodId,StatusId) values
('elysia.doan@avepoint.com',1, 1, 1),
('1100@gmail.com',1, 2, 1),
('2200@gmail.com',1, 1, 1),
('3300@gmail.com',2, 1, 1),
('4400@gmail.com',2, 1, 1);
