pipeline {
	agent none
	
	environment {
		VAL = 'ola'
		BRANCHNAME = $(BRANCH_NAME)
	}
	
	stages {
		stage('pre') {
			steps {
				echo 'NO BRANCH MAIN'
			}
		}
		stage('pre2') {
			when {
				expression {
					env.VAL == 'ola'
				} 
			} 
			steps {
				echo 'igual'
			}
		}
		stage('checkout') {
			agent any
			steps {
				echo 'checkout do BRANCH->$(env.BRANCHNAME)'
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


