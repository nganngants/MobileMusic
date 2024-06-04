-- create database MobileMusic
use MobileMusic

create table song (
	id int identity(1,1) primary key,
	name nvarchar(128) not null,
	singer nvarchar(128),
	category varchar(64) check (category in ('US-UK', 'V-pop', 'K-pop')),
	filename varchar(128),
	thumbnail varchar(128),
	last_played smalldatetime,
	is_favorite int check (is_favorite in (0, 1)) default 0
)

go

create table playlist (
	id int identity(1,1) primary key,
	name nvarchar(128) not null,
	thumbnail varchar(128)
)

go
create table playlist_song (
	playlist_id int foreign key references playlist(id),
	song_id int foreign key references song(id),
	constraint pk_playlist_song primary key(playlist_id, song_id)
)

go

create table download (
	id int identity(1,1) primary key,
	song_id int foreign key references song(id),
	downloaded_time smalldatetime
)

go

create table comment (
	id int identity(1,1) primary key,
	song_id int foreign key references song(id),
	display_name nvarchar(256), 
	comment nvarchar(256),
	comment_time smalldatetime
)
insert into comment values(12, 'User 1', 'hay!', '3/30/2024 13:03:00')
select * from song
select * from download
update song 
set thumbnail = '02.jpg'
where id = 2

