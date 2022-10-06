pipeline {
	agent none
	
	environment {
		VAL = 'ola'
	}
	
	stages {
		stage('pre') {
			steps {
				echo 'NO BRANCH MAIN'
			}
		}
		stage('checkout') {
			agent any
			steps {
				checkout scm
			}		
		}
		stage('build') {
			steps {
				echo '$(BUILD_ID)->$(JOB_NAME):$(BUILD_NAME)'
			}
		}
	}
	
	post {
		success {
			echo 'Sucesso'
		}
		failure {
			echo 'Erro'
		}
	}
}


