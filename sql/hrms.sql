/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : hrms

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2013-11-13 22:43:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tb_addressbook`
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
-- Table structure for `tb_blotter`
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
-- Table structure for `tb_branch`
-- ----------------------------
DROP TABLE IF EXISTS `tb_branch`;
CREATE TABLE `tb_branch` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `branchNum` varchar(100) DEFAULT NULL,
  `branchName` varchar(100) DEFAULT NULL,
  `branchInfo` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gb2312;

-- ----------------------------
-- Records of tb_branch
-- ----------------------------
INSERT INTO `tb_branch` VALUES ('1', 'aa', '总经办', '信息');
INSERT INTO `tb_branch` VALUES ('2', null, '开发部', null);
INSERT INTO `tb_branch` VALUES ('3', null, 'a', null);
INSERT INTO `tb_branch` VALUES ('4', null, 'a', null);
INSERT INTO `tb_branch` VALUES ('5', null, 'v', null);
INSERT INTO `tb_branch` VALUES ('6', 'v', 'v', 'v');
INSERT INTO `tb_branch` VALUES ('7', 'ca', 'cc', 'as');
INSERT INTO `tb_branch` VALUES ('8', 'v', 'a', 'c');

-- ----------------------------
-- Table structure for `tb_family`
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
-- Table structure for `tb_folk`
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
-- Table structure for `tb_headship`
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
-- Table structure for `tb_perinfo`
-- ----------------------------
DROP TABLE IF EXISTS `tb_perinfo`;
CREATE TABLE `tb_perinfo` (
  `id` int(11) NOT NULL,
  `perNum` varchar(100) NOT NULL,
  `perName` varchar(100) NOT NULL,
  `folk` varchar(100) DEFAULT NULL,
  `birthday` varchar(100) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `kultur` varchar(100) DEFAULT NULL,
  `marriage` varchar(100) DEFAULT NULL,
  `sex` varchar(50) DEFAULT NULL,
  `visage` varchar(50) DEFAULT NULL,
  `IDCard` varchar(100) DEFAULT NULL,
  `origo` varchar(100) DEFAULT NULL,
  `workDate` varchar(100) DEFAULT NULL,
  `workLength` varchar(100) DEFAULT NULL,
  `employee` varchar(100) DEFAULT NULL,
  `intoWorkDate` varchar(100) DEFAULT NULL,
  `intoWorkLength` int(100) DEFAULT NULL,
  `laborageType` varchar(100) DEFAULT NULL,
  `branch` varchar(100) DEFAULT NULL,
  `headship` varchar(100) DEFAULT NULL,
  `ZhiChen` varchar(100) DEFAULT NULL,
  `phone` varchar(100) DEFAULT NULL,
  `handset` varchar(100) DEFAULT NULL,
  `school` varchar(100) DEFAULT NULL,
  `speciality` varchar(100) DEFAULT NULL,
  `GraduateDate` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `photoImage` blob
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tb_perinfo
-- ----------------------------
INSERT INTO `tb_perinfo` VALUES ('0', '1', '丁一', '汉族', '1987.6.20', '26', '本科', '本科', '男', '群众', '371312198706206418', '山东临沂', '2010', '3', '正式员工', '2012', '2', '普通工资', '总经办', '经理', '工程师', '8829568', '18601324477', '青大', '网络工程', '2010', '霍营', 0x436F6E666967652E626D70);

-- ----------------------------
-- Table structure for `tb_users`
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
-- Table structure for `tb_workresume`
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
-- Table structure for `tb_zhichen`
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
