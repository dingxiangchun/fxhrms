/*
Navicat MySQL Data Transfer

Source Server         : hrms
Source Server Version : 50519
Source Host           : localhost:3306
Source Database       : hrms

Target Server Type    : MYSQL
Target Server Version : 50519
File Encoding         : 65001

Date: 2013-11-28 20:48:12
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for tb_addressbook
-- ----------------------------
DROP TABLE IF EXISTS `tb_addressbook`;
CREATE TABLE `tb_addressbook` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uName` varchar(100) DEFAULT NULL,
  `sex` varchar(50) DEFAULT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `handset` varchar(100) DEFAULT NULL,
  `workPhone` varchar(100) DEFAULT NULL,
  `QQ` varchar(20) DEFAULT NULL,
  `e_mail` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_addressbook
-- ----------------------------
INSERT INTO `tb_addressbook` VALUES ('1', '丁一', '男', '8829568', '18601324477', '8829568', '454059034', '454059034@qq.com');

-- ----------------------------
-- Table structure for tb_blotter
-- ----------------------------
DROP TABLE IF EXISTS `tb_blotter`;
CREATE TABLE `tb_blotter` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `noteDate` varchar(100) DEFAULT NULL,
  `noteSort` varchar(100) DEFAULT NULL,
  `tTitle` text,
  `tContent` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_blotter
-- ----------------------------
INSERT INTO `tb_blotter` VALUES ('1', '2012-03-04', '日志', '标题', '内容测试');

-- ----------------------------
-- Table structure for tb_branch
-- ----------------------------
DROP TABLE IF EXISTS `tb_branch`;
CREATE TABLE `tb_branch` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `branchNum` varchar(100) DEFAULT NULL,
  `branchName` varchar(100) DEFAULT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `person` varchar(50) DEFAULT NULL,
  `branchInfo` text,
  `parentid` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_branch
-- ----------------------------
INSERT INTO `tb_branch` VALUES ('0', null, '费县农商银行', null, null, null, null);
INSERT INTO `tb_branch` VALUES ('3', '33', '第一支行', null, null, '14', '0');
INSERT INTO `tb_branch` VALUES ('4', null, '第二支行', null, null, null, '0');
INSERT INTO `tb_branch` VALUES ('5', null, '办事处1', null, null, null, '3');
INSERT INTO `tb_branch` VALUES ('6', 'v', '办事处2', null, null, 'v', '3');
INSERT INTO `tb_branch` VALUES ('7', 'ca', '办事处3', null, null, 'as', '4');
INSERT INTO `tb_branch` VALUES ('8', 'v', '后勤', null, null, 'c', '3');
INSERT INTO `tb_branch` VALUES ('10', '12', 'department', null, null, 'testinfo', '3');
INSERT INTO `tb_branch` VALUES ('11', '12', '业务组', null, null, '业务处理', '5');
INSERT INTO `tb_branch` VALUES ('12', '22', '业务组2', null, null, '', '5');
INSERT INTO `tb_branch` VALUES ('13', '123', '办事处3', null, null, '123', '3');
INSERT INTO `tb_branch` VALUES ('14', '22', '办事处4', '', '', '111', '3');
INSERT INTO `tb_branch` VALUES ('15', '111', '纪委', '2222', '3333', '44444', '4');

-- ----------------------------
-- Table structure for tb_family
-- ----------------------------
DROP TABLE IF EXISTS `tb_family`;
CREATE TABLE `tb_family` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  `relation` varchar(100) DEFAULT NULL,
  `birth` varchar(100) DEFAULT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `situation` varchar(200) DEFAULT NULL,
  `remark` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_family
-- ----------------------------
INSERT INTO `tb_family` VALUES ('1', '2', '丁', '父亲', '1956-08-16', '12312321', '山东临沂', '群众', '在岗', '321');
INSERT INTO `tb_family` VALUES ('2', '2', '刘', '母亲', '1960-10-16', '12312', '山东临沂', '群众', '退休', '123');
INSERT INTO `tb_family` VALUES ('3', '2', '丁', '子女', '1983-6-10', '333333', '山东临沂', '其他', '其他', '222');

-- ----------------------------
-- Table structure for tb_folk
-- ----------------------------
DROP TABLE IF EXISTS `tb_folk`;
CREATE TABLE `tb_folk` (
  `fid` int(11) NOT NULL AUTO_INCREMENT,
  `folkName` varchar(100) NOT NULL,
  PRIMARY KEY (`fid`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_folk
-- ----------------------------
INSERT INTO `tb_folk` VALUES ('22', '汉族');
INSERT INTO `tb_folk` VALUES ('23', '少数民族');

-- ----------------------------
-- Table structure for tb_headship
-- ----------------------------
DROP TABLE IF EXISTS `tb_headship`;
CREATE TABLE `tb_headship` (
  `hid` int(11) NOT NULL AUTO_INCREMENT,
  `hName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`hid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_headship
-- ----------------------------
INSERT INTO `tb_headship` VALUES ('1', '经理');
INSERT INTO `tb_headship` VALUES ('2', '总裁');

-- ----------------------------
-- Table structure for tb_holidayrecords
-- ----------------------------
DROP TABLE IF EXISTS `tb_holidayrecords`;
CREATE TABLE `tb_holidayrecords` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `holiday` varchar(100) DEFAULT NULL,
  `days` float DEFAULT NULL,
  `reason` varchar(200) DEFAULT NULL,
  `audit` varchar(50) DEFAULT NULL,
  `begintime` varchar(50) DEFAULT NULL,
  `Endtime` varchar(50) DEFAULT NULL,
  `days1` float DEFAULT NULL,
  `remark` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_holidayrecords
-- ----------------------------
INSERT INTO `tb_holidayrecords` VALUES ('1', '2', 'h', '1', 'sd', 'asda', '2012-10-01', '2012-10-02', '1', '');

-- ----------------------------
-- Table structure for tb_learninfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_learninfo`;
CREATE TABLE `tb_learninfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `degree` varchar(50) DEFAULT NULL,
  `starttime` varchar(50) DEFAULT NULL,
  `graduatetime` varchar(50) DEFAULT NULL,
  `graduatesch` varchar(100) DEFAULT NULL,
  `retence` varchar(50) DEFAULT NULL,
  `profession` varchar(100) DEFAULT NULL,
  `content` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_learninfo
-- ----------------------------
INSERT INTO `tb_learninfo` VALUES ('1', '2', '博士', '1995-08', '1999-09-01', '临沂二小', '张某某', '班长', '');
INSERT INTO `tb_learninfo` VALUES ('2', '2', '硕士', '1999-07-01', '2002-09-01', '临沂十三中', '刘某某', '学习委员', '');
INSERT INTO `tb_learninfo` VALUES ('3', '2', '大专', '2002-07-01', '2006-09-01', '河东一中', '谢某某', '班长', '123');

-- ----------------------------
-- Table structure for tb_perinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_perinfo`;
CREATE TABLE `tb_perinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Beforename` varchar(50) DEFAULT NULL,
  `Employeeid` varchar(100) DEFAULT NULL,
  `Sex` varchar(10) DEFAULT NULL,
  `Nation` varchar(20) DEFAULT NULL,
  `Birth` varchar(100) DEFAULT NULL,
  `Idcard` varchar(50) DEFAULT NULL,
  `UnitID` int(11) DEFAULT NULL,
  `Unit` varchar(200) DEFAULT NULL,
  `Position` varchar(100) DEFAULT NULL,
  `Rank` varchar(20) DEFAULT NULL,
  `Level` int(11) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `Statustime` varchar(50) DEFAULT NULL,
  `Jobtime` varchar(50) DEFAULT NULL,
  `financetime` varchar(50) DEFAULT NULL,
  `fulltime_educ` varchar(50) DEFAULT NULL,
  `fulltime_sch` varchar(100) DEFAULT NULL,
  `Major` varchar(100) DEFAULT NULL,
  `Married` varchar(10) DEFAULT NULL,
  `Town` varchar(200) DEFAULT NULL,
  `Tel` varchar(20) DEFAULT NULL,
  `final_sch` varchar(100) DEFAULT NULL,
  `final_edu` varchar(100) DEFAULT NULL,
  `final_emajior` varchar(100) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `Reserve` varchar(100) DEFAULT NULL,
  `Guard` varchar(50) DEFAULT NULL,
  `Ages` int(10) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  `employclass` varchar(100) DEFAULT NULL,
  `photo` varchar(200) DEFAULT NULL,
  `Attrion` varchar(100) DEFAULT NULL,
  `BankcardID` varchar(100) DEFAULT NULL,
  `remarks1` varchar(200) DEFAULT NULL,
  `remarks2` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_perinfo
-- ----------------------------
INSERT INTO `tb_perinfo` VALUES ('2', '丁一', null, '010', '男', '汉族', '1987-12-20', '371312198706206418', '0', '1', '1', '普通员工', '1', '群众', null, '2010-07-01', '2010-07-01', '本科', '青岛大学', '网络工程', '未婚', '山东临沂', '8829568', '青岛大学', '网络工程', null, '山东临沂', '1', '', '0', '', null, '/Photo/200961992038.jpg', null, null, null, null);
INSERT INTO `tb_perinfo` VALUES ('3', 'mr.wamg', null, '011', '男', '汉族', '1987-06-20', '371312198706206418', '3', '1', '1', '普通员工', '1', '群众', null, '2013-11-05', '2013-11-14', '本科', 'wqeqwe', 'efwef', '未婚', 'faef', 'fwe', 'wfew', 'fwe', null, 'afwef', '', 'afwf', '0', '1', null, '/Photo/130299039326897491.jpeg', null, null, null, null);
INSERT INTO `tb_perinfo` VALUES ('4', 'ding', null, '033', '男', '汉族', '1987-06-20', '371312198706206418', '4', '2', '2', '普通员工', '1', '群众', null, '', '', '本科', '', '', '未婚', '', '', '', '', null, '', '2', '', '0', '2', null, '', null, null, null, null);

-- ----------------------------
-- Table structure for tb_pertypeinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_pertypeinfo`;
CREATE TABLE `tb_pertypeinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `info` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_pertypeinfo
-- ----------------------------
INSERT INTO `tb_pertypeinfo` VALUES ('1', '在职', null);
INSERT INTO `tb_pertypeinfo` VALUES ('2', '离职', null);
INSERT INTO `tb_pertypeinfo` VALUES ('4', '退休', '年满60');

-- ----------------------------
-- Table structure for tb_positioninfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_positioninfo`;
CREATE TABLE `tb_positioninfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `info` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_positioninfo
-- ----------------------------
INSERT INTO `tb_positioninfo` VALUES ('1', '业务副经理', '处理相关业务');
INSERT INTO `tb_positioninfo` VALUES ('2', '普通柜员', null);
INSERT INTO `tb_positioninfo` VALUES ('3', '金融理财客户经理', '');

-- ----------------------------
-- Table structure for tb_registerinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_registerinfo`;
CREATE TABLE `tb_registerinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `cer_name` varchar(100) DEFAULT NULL,
  `accesstime` varchar(50) DEFAULT NULL,
  `issuingtime` varchar(50) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `Class` varchar(50) DEFAULT NULL,
  `photo` varchar(200) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_registerinfo
-- ----------------------------
INSERT INTO `tb_registerinfo` VALUES ('1', '2', '毕业证', '高中毕业证', '2006-09-01', '2006-09-01', '临沂十三中', '县级', '', '');

-- ----------------------------
-- Table structure for tb_reserve
-- ----------------------------
DROP TABLE IF EXISTS `tb_reserve`;
CREATE TABLE `tb_reserve` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ReserveType` varchar(100) DEFAULT NULL,
  `ReserveInfo` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_reserve
-- ----------------------------
INSERT INTO `tb_reserve` VALUES ('1', '管理人才', null);
INSERT INTO `tb_reserve` VALUES ('2', '技术性人才', null);

-- ----------------------------
-- Table structure for tb_resumeinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_resumeinfo`;
CREATE TABLE `tb_resumeinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `attacktime` varchar(50) DEFAULT NULL,
  `quittime` varchar(100) DEFAULT NULL,
  `position` varchar(100) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `mark` int(10) unsigned zerofill DEFAULT NULL,
  `reason` text,
  `content` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_resumeinfo
-- ----------------------------
INSERT INTO `tb_resumeinfo` VALUES ('1', '2', '2011-10-01', '2012-10-01', '业务员', '第一支行', null, '调职', '2312');

-- ----------------------------
-- Table structure for tb_rewardinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_rewardinfo`;
CREATE TABLE `tb_rewardinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `employeeid` varchar(100) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `time` varchar(50) DEFAULT NULL,
  `content` text,
  `department` varchar(100) DEFAULT NULL,
  `audit` varchar(20) DEFAULT NULL,
  `Class` varchar(50) DEFAULT NULL,
  `level` varchar(50) DEFAULT NULL,
  `unit` varchar(100) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL,
  `mark` int(11) unsigned zerofill DEFAULT NULL,
  `File` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_rewardinfo
-- ----------------------------
INSERT INTO `tb_rewardinfo` VALUES ('1', '2', '奖罚', '2010-10-01', '三等奖学金', '青岛大学', '赵某某', '3434', null, '丁一', '2222', null, '');

-- ----------------------------
-- Table structure for tb_users
-- ----------------------------
DROP TABLE IF EXISTS `tb_users`;
CREATE TABLE `tb_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `loginname` varchar(100) DEFAULT NULL,
  `userpwd` varchar(100) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  `userprower` int(11) DEFAULT '0',
  `Unit` varchar(100) DEFAULT NULL,
  `remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_users
-- ----------------------------
INSERT INTO `tb_users` VALUES ('1', 'admin', '123', '', '0', '', '');
INSERT INTO `tb_users` VALUES ('2', 'input', '123', '', '1', null, null);
INSERT INTO `tb_users` VALUES ('3', 'user', '123', null, '2', null, null);

-- ----------------------------
-- Table structure for tb_workresume
-- ----------------------------
DROP TABLE IF EXISTS `tb_workresume`;
CREATE TABLE `tb_workresume` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `perID` varchar(100) DEFAULT NULL,
  `beginDate` varchar(100) DEFAULT NULL,
  `endDate` varchar(100) DEFAULT NULL,
  `branch` varchar(100) DEFAULT NULL,
  `headship` varchar(100) DEFAULT NULL,
  `IncName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_workresume
-- ----------------------------

-- ----------------------------
-- Table structure for tb_zhichen
-- ----------------------------
DROP TABLE IF EXISTS `tb_zhichen`;
CREATE TABLE `tb_zhichen` (
  `ZCID` int(11) NOT NULL AUTO_INCREMENT,
  `ZCName` varchar(100) NOT NULL,
  PRIMARY KEY (`ZCID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_zhichen
-- ----------------------------
INSERT INTO `tb_zhichen` VALUES ('1', '工程师');
INSERT INTO `tb_zhichen` VALUES ('2', '架构师');
