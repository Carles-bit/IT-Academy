-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Employee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Employee` (
  `idEmployee` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idEmployee`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Custumer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Custumer` (
  `idCustumer` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `address` VARCHAR(200) NULL,
  `tel` DECIMAL(9) NULL,
  `email` VARCHAR(45) NULL,
  `registrationDate` DATETIME NULL,
  `recommendedCustumer` INT NULL,
  PRIMARY KEY (`idCustumer`),
  INDEX `fk_Custumer_Custumer1_idx` (`recommendedCustumer` ASC) VISIBLE,
  CONSTRAINT `fk_Custumer_Custumer1`
    FOREIGN KEY (`recommendedCustumer`)
    REFERENCES `mydb`.`Custumer` (`idCustumer`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Invoce`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Invoce` (
  `idInvoce` INT NOT NULL,
  `Employee_idEmployee` INT NOT NULL,
  `date` DATETIME NOT NULL,
  `state` INT NOT NULL,
  `Custumer_idCustumer` INT NOT NULL,
  PRIMARY KEY (`idInvoce`),
  INDEX `fk_Invoce_Employee1_idx` (`Employee_idEmployee` ASC) VISIBLE,
  INDEX `fk_Invoce_Custumer1_idx` (`Custumer_idCustumer` ASC) VISIBLE,
  CONSTRAINT `fk_Invoce_Employee1`
    FOREIGN KEY (`Employee_idEmployee`)
    REFERENCES `mydb`.`Employee` (`idEmployee`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Invoce_Custumer1`
    FOREIGN KEY (`Custumer_idCustumer`)
    REFERENCES `mydb`.`Custumer` (`idCustumer`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Provider`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Provider` (
  `nif` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `street` VARCHAR(45) NULL,
  `number` INT NULL,
  `floor` VARCHAR(45) NULL,
  `door` VARCHAR(45) NULL,
  `city` VARCHAR(45) NULL,
  `postalCode` INT NULL,
  `country` VARCHAR(45) NULL,
  `tel` VARCHAR(15) NULL,
  `fax` VARCHAR(15) NULL,
  PRIMARY KEY (`nif`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`marca` (
  `idmarca` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `Provider_nif` INT NOT NULL,
  PRIMARY KEY (`idmarca`),
  INDEX `fk_marca_Provider1_idx` (`Provider_nif` ASC) VISIBLE,
  CONSTRAINT `fk_marca_Provider1`
    FOREIGN KEY (`Provider_nif`)
    REFERENCES `mydb`.`Provider` (`nif`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Glasses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Glasses` (
  `idGlasses` INT NOT NULL,
  `marca_idmarca` INT NOT NULL,
  `mocel` VARCHAR(45) NULL,
  `description` VARCHAR(45) NULL,
  `price` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`idGlasses`),
  INDEX `fk_Glasses_marca1_idx` (`marca_idmarca` ASC) VISIBLE,
  CONSTRAINT `fk_Glasses_marca1`
    FOREIGN KEY (`marca_idmarca`)
    REFERENCES `mydb`.`marca` (`idmarca`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`InvoceDetail`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`InvoceDetail` (
  `idInvoceDetail` INT NOT NULL,
  `Invoce_idInvoce` INT NOT NULL,
  `Glasses_idGlasses` INT NOT NULL,
  `quantity` INT NULL,
  `unitPrice` VARCHAR(45) NULL,
  `graduationR` DECIMAL(4,2) NULL,
  `graduationL` DECIMAL(4,2) NULL,
  `montura` INT NULL,
  `colorGlasses` INT NULL,
  `colorGlassR` INT NULL,
  `colorGlassL` INT NULL,
  INDEX `fk_InvoceDetail_Invoce1_idx` (`Invoce_idInvoce` ASC) VISIBLE,
  INDEX `fk_InvoceDetail_Glasses1_idx` (`Glasses_idGlasses` ASC) VISIBLE,
  CONSTRAINT `fk_InvoceDetail_Invoce1`
    FOREIGN KEY (`Invoce_idInvoce`)
    REFERENCES `mydb`.`Invoce` (`idInvoce`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_InvoceDetail_Glasses1`
    FOREIGN KEY (`Glasses_idGlasses`)
    REFERENCES `mydb`.`Glasses` (`idGlasses`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
