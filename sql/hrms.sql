/*
Navicat MySQL Data Transfer

Source Server         : hrms
Source Server Version : 50519
Source Host           : localhost:3306
Source Database       : hrms

Target Server Type    : MYSQL
Target Server Version : 50519
File Encoding         : 65001

Date: 2013-11-16 13:51:38
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
  `branchInfo` text,
  `parentid` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_branch
-- ----------------------------
INSERT INTO `tb_branch` VALUES ('2', null, '费县农商银行', null, null);
INSERT INTO `tb_branch` VALUES ('3', null, '第一支行', null, '2');
INSERT INTO `tb_branch` VALUES ('4', null, '第二支行', null, '2');
INSERT INTO `tb_branch` VALUES ('5', null, '办事处1', null, '3');
INSERT INTO `tb_branch` VALUES ('6', 'v', '办事处2', 'v', '3');
INSERT INTO `tb_branch` VALUES ('7', 'ca', '办事处3', 'as', '4');
INSERT INTO `tb_branch` VALUES ('8', 'v', '后勤', 'c', '3');
INSERT INTO `tb_branch` VALUES ('10', '12', 'department', 'testinfo', '3');

-- ----------------------------
-- Table structure for tb_family
-- ----------------------------
DROP TABLE IF EXISTS `tb_family`;
CREATE TABLE `tb_family` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `perID` varchar(100) DEFAULT NULL,
  `LeaguerName` varchar(100) DEFAULT NULL,
  `Nexus` varchar(100) DEFAULT NULL,
  `BirthDate` varchar(100) DEFAULT NULL,
  `WorkInc` varchar(100) DEFAULT NULL,
  `headship` varchar(100) DEFAULT NULL,
  `visage` varchar(100) DEFAULT NULL,
  `phone` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_family
-- ----------------------------

-- ----------------------------
-- Table structure for tb_folk
-- ----------------------------
DROP TABLE IF EXISTS `tb_folk`;
CREATE TABLE `tb_folk` (
  `fid` int(11) NOT NULL AUTO_INCREMENT,
  `folkName` varchar(100) NOT NULL,
  PRIMARY KEY (`fid`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

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
-- Table structure for tb_perinfo
-- ----------------------------
DROP TABLE IF EXISTS `tb_perinfo`;
CREATE TABLE `tb_perinfo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Employeeid` varchar(100) DEFAULT NULL,
  `Sex` varchar(10) DEFAULT NULL,
  `Nation` varchar(20) DEFAULT NULL,
  `Birth` varchar(50) DEFAULT NULL,
  `Idcard` varchar(50) DEFAULT NULL,
  `UnitID` int(11) DEFAULT NULL,
  `Unit` varchar(200) DEFAULT NULL,
  `Position` varchar(100) DEFAULT NULL,
  `Rank` varchar(20) DEFAULT NULL,
  `Level` varchar(50) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
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
  `Address` varchar(200) DEFAULT NULL,
  `Reserve` varchar(100) DEFAULT NULL,
  `Guard` varchar(50) DEFAULT NULL,
  `Ages` varchar(10) DEFAULT NULL,
  `Class` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_perinfo
-- ----------------------------
INSERT INTO `tb_perinfo` VALUES ('1', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for tb_users
-- ----------------------------
DROP TABLE IF EXISTS `tb_users`;
CREATE TABLE `tb_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(100) NOT NULL,
  `userPwd` varchar(100) NOT NULL,
  `userGroup` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_users
-- ----------------------------
INSERT INTO `tb_users` VALUES ('1', '1', '1', '0');
INSERT INTO `tb_users` VALUES ('2', '', '', '1');

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
